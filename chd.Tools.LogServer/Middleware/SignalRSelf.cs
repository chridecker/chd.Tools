using chd.Tools.LogServer.Extensions;
using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR.Protocol;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace chd.Tools.LogServer.Middleware
{
    public class SignalRSelf(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context, AppSettings settings, SignalRCache cache, CallLogger callLogger)
        {
            if (string.IsNullOrWhiteSpace(settings.ForwardUrl)
                && !context.WebSockets.IsWebSocketRequest
                && context.Request is { Method: "POST", Path.HasValue: true }
                && context.Request.Path.Value.EndsWith("negotiate"))
            {
                context.Response.StatusCode = (int)settings.ResponseStatusCode;
                context.Response.ContentType = "application/json";
                var negotiate = new SignalRNegotiateResponse()
                {
                    NegotiateVersion = context.Request.Query.TryGetValue("negotiateVersion", out var v) && int.TryParse(v, out var version) ? version : 0,
                    ConnectionId = NewId(),
                    ConnectionToken = NewId(),
                    AvailableTransports = [new ()
                    {
                        Transport = "WebSockets",
                        TransferFormats = ["Text", "Binary"]
                    },
                        new ()
                    {
                        Transport = "ServerSentEvents",
                        TransferFormats = ["Text"]
                    },
                        new ()
                    {
                        Transport = "LongPolling",
                        TransferFormats = ["Text", "Binary"]
                    }]
                };
                var json = JsonSerializer.Serialize(negotiate);
                callLogger.CallResponse = json;
                await context.Response.WriteAsJsonAsync(negotiate, context.RequestAborted);
                return;
            }

            else if (string.IsNullOrWhiteSpace(settings.ForwardUrl)
               && context.WebSockets.IsWebSocketRequest)
            {
                var dto = new SignalRConnectionDto();
                await dto.Initialize(context);

                using var client = await context.WebSockets.AcceptWebSocketAsync();

                dto.Connected = true;
                dto.SetClient(client);
                cache.Add(dto);

                try
                {
                    await Handle(client, dto, context.RequestAborted);
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

        static string NewId()
        {
            Span<byte> bytes = stackalloc byte[16];
            RandomNumberGenerator.Fill(bytes);
            return Convert.ToBase64String(bytes)
                .TrimEnd('=')
                .Replace('+', '-')
                .Replace('/', '_');
        }

        static async Task Handle(WebSocket client, SignalRConnectionDto dto, CancellationToken ct)
        {
            var established = false;
            var buffer = new byte[16 * 1024];
            using var message = new MemoryStream();

            while (!ct.IsCancellationRequested)
            {

                var r = await client.ReceiveAsync(buffer, ct);
                if (r.MessageType == WebSocketMessageType.Close)
                {
                    break;
                }

                message.Write(buffer, 0, r.Count);

                if (!r.EndOfMessage)
                {
                    continue;
                }

                var data = ReadData(message.ToArray(), r.MessageType);
                if (!established)
                {
                    await client.SendAsync(buffer.AsMemory(0, r.Count), WebSocketMessageType.Text,
                        WebSocketMessageFlags.EndOfMessage, ct);
                    established = true;

                    Ping(client, dto, ct);
                }

                foreach (var msg in GetMessages(data))
                {
                    msg.Data = data;
                    msg.Direction = "Receive";
                    msg.Type = r.MessageType;
                    if (msg.MessageType is SignalRMessageType.Ping)
                    {
                        await client.SendAsync(buffer.AsMemory(0, r.Count), WebSocketMessageType.Text, WebSocketMessageFlags.EndOfMessage, ct);
                        dto.AddMessage(new SignalRPingMessage()
                        {
                            Direction = "Send",
                            Data = data,
                            Type = r.MessageType
                        });
                    }

                    dto.AddMessage(msg);
                }

                message.SetLength(0);
            }
        }

        private static void Ping(WebSocket client, SignalRConnectionDto dto, CancellationToken cancellationToken) => Task.Run(async () =>
        {
            var timer = new PeriodicTimer(TimeSpan.FromSeconds(6));
            while (await timer.WaitForNextTickAsync(cancellationToken))
            {
                var ping = "{\"type\":6}\u001e";

                using var ms = new MemoryStream(Encoding.Default.GetBytes(ping));

                await client.SendAsync(ms.ToArray(), WebSocketMessageType.Text, WebSocketMessageFlags.EndOfMessage,
                    cancellationToken);
                dto.AddMessage(new SignalRPingMessage()
                {
                    Direction = "Send",
                    Data = ping,
                    Type = WebSocketMessageType.Text
                });

            }
        }, cancellationToken);


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
