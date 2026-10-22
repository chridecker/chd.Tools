using chd.Tools.LogServer.Extensions;
using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;
using Microsoft.AspNetCore.SignalR.Protocol;
using System.Net.WebSockets;
using System.Text;

namespace chd.Tools.LogServer.Middleware
{
    public class SignalRForward(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context, AppSettings settings, SignalRCache cache)
        {
             if (!string.IsNullOrWhiteSpace(settings.ForwardUrl)
                && context.WebSockets.IsWebSocketRequest)
            {
                var dto = new SignalRConnectionDto();
                await dto.Initialize(context);
                dto.ForwardUrl = settings.ForwardUrl;

                var http = new Uri(
                    $"{settings.ForwardUrl.TrimEnd('/')}{context.Request.Path}{context.Request.QueryString}");
                var wsUri = new UriBuilder(http)
                {
                    Scheme = http.Scheme == Uri.UriSchemeHttps ? Uri.UriSchemeWss : Uri.UriSchemeWs
                }.Uri;

                using var upstream = new ClientWebSocket();
                upstream.Options.CollectHttpResponseDetails = true;

                foreach (var p in context.WebSockets.WebSocketRequestedProtocols)
                {
                    upstream.Options.AddSubProtocol(p);
                }

                // Auth: Header 1:1 durchreichen, sonst access_token aus dem Query als Bearer setzen
                if (context.Request.Headers.TryGetValue("Authorization", out var auth))
                {
                    upstream.Options.SetRequestHeader("Authorization", auth.ToString());
                }
                else if (context.Request.Query.TryGetValue("access_token", out var token))
                {
                    upstream.Options.SetRequestHeader("Authorization", $"Bearer {token}");
                }
                else if (context.Request.Headers.TryGetValue("x-api-key", out var apiKey))
                {
                    upstream.Options.SetRequestHeader("x-api-key", apiKey.ToString());
                }

                foreach (var name in new[] { "Cookie", "User-Agent" })
                {
                    if (context.Request.Headers.TryGetValue(name, out var v))
                    {
                        upstream.Options.SetRequestHeader(name, v.ToString());
                    }
                }

                try
                {
                    await upstream.ConnectAsync(wsUri, context.RequestAborted);
                }
                catch (Exception ex)
                {
                    context.Response.StatusCode = StatusCodes.Status502BadGateway;
                    return;
                }

                // Erst nach erfolgreichem Upstream-Connect den Client annehmen,
                // damit das ausgehandelte Subprotocol übernommen werden kann
                using var client = await context.WebSockets.AcceptWebSocketAsync(upstream.SubProtocol);

                using var cts = CancellationTokenSource.CreateLinkedTokenSource(context.RequestAborted);

                dto.Connected = true;
                cache.Add(dto);

                var t1 = Pump(client, upstream, dto, "Send", cts.Token);
                var t2 = Pump(upstream, client, dto, "Receive", cts.Token);

                await Task.WhenAny(t1, t2);
                cts.Cancel();
                try
                {
                    await Task.WhenAll(t1, t2);
                }
                catch (OperationCanceledException)
                {
                }
                catch (WebSocketException)
                {
                }
                dto.Connected = false;
                return;
            }

            await next(context);
        }
        static async Task Pump(WebSocket from, WebSocket to, SignalRConnectionDto dto, string direction, CancellationToken ct)
        {
            var buffer = new byte[16 * 1024];
            using var message = new MemoryStream();

            while (!ct.IsCancellationRequested)
            {
                var r = await from.ReceiveAsync(buffer, ct);

                if (r.MessageType == WebSocketMessageType.Close)
                {
                    if (to.State is WebSocketState.Open or WebSocketState.CloseReceived)
                        await to.CloseOutputAsync(r.CloseStatus ?? WebSocketCloseStatus.NormalClosure,
                            r.CloseStatusDescription, CancellationToken.None);
                    break;
                }

                await to.SendAsync(buffer.AsMemory(0, r.Count), r.MessageType, r.EndOfMessage, ct);

                message.Write(buffer, 0, r.Count);


                if (!r.EndOfMessage)
                {
                    continue;
                }

                var data = ReadData(message.ToArray(), r.MessageType);

                foreach (var msg in GetMessages(data))
                {
                    msg.Data = data;
                    msg.Direction = direction;
                    msg.Type = r.MessageType;
                    dto.AddMessage(msg);
                }

                message.SetLength(0);
            }
        }

        static string ReadData(byte[] data, WebSocketMessageType type)
        => type is WebSocketMessageType.Text ? Encoding.UTF8.GetString(data) : Convert.ToHexString(data.AsSpan(0, Math.Min(data.Length, 256)));

        static IEnumerable<SignalRMessage> GetMessages(string json)
            => json.ParseFrame().Select(s => Parse(s.Type, s.Json));

        private static SignalRMessage Parse(SignalRMessageType type, string json) => (type) switch
        {
            SignalRMessageType.Invocation => new SignalRInvocationMessage(json.RootValue("target"), json.RootValueArray("arguments")),
            SignalRMessageType.Ping => new SignalRPingMessage(),
            _ => new SignalRMessage(SignalRMessageType.None)
        };
    }
}
