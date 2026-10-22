using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;
using System.Net.WebSockets;

namespace chd.Tools.LogServer.Middleware
{
    public class SignalRForward(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context, AppSettings settings, IHttpClientFactory httpClientFactory,
            CallLogger callLogger)
        {
            if (!string.IsNullOrWhiteSpace(settings.ForwardUrl)
                && context.WebSockets.IsWebSocketRequest)
            {
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

                var t1 = Pump(client, upstream, cts.Token);
                var t2 = Pump(upstream, client, cts.Token);

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

                return;
            }
        }
        static async Task Pump(WebSocket from, WebSocket to, CancellationToken ct)
        {
            var buffer = new byte[16 * 1024];
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
            }
        }
    }
}
