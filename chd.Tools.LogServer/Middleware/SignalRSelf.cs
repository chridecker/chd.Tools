using System.Collections.Concurrent;
using chd.Tools.LogServer.Extensions;
using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR.Protocol;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
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
                    await Handle(client, dto, cache, context.RequestAborted);
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

        static async Task Handle(WebSocket client, SignalRConnectionDto dto, SignalRCache cache, CancellationToken ct)
        {
            var established = false;
            var buffer = new byte[16 * 1024];

            var receivesStreams = new ConcurrentDictionary<string, Channel<object>>();
            var openStreamInvocations = new ConcurrentDictionary<string, string>();

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
                    continue;
                }


                foreach (var (msg, json) in GetMessages(data))
                {
                    msg.Data = json;
                    msg.Direction = "Receive";
                    msg.Type = r.MessageType;
                    if (msg.MessageType is SignalRMessageType.Invocation
                        && msg is SignalRReceiveStreamInvocationMessage streamReceive
                        && streamReceive.Streams.Any())
                    {
                        openStreamInvocations[streamReceive.Streams[0]] = streamReceive.InvocationId;
                        receivesStreams[streamReceive.Streams[0]] =
                            Channel.CreateBounded<object>(new BoundedChannelOptions(1000));
                    }

                    if (msg.MessageType is SignalRMessageType.Close
                        && msg is SignalRCloseMessage close)
                    {

                    }
                    if (msg.MessageType is SignalRMessageType.StreamItem
                        && msg is SignalRStreamItemMessage item
                        && receivesStreams.TryGetValue(item.InvocationId, out var channel))
                    {
                        await channel.Writer.WriteAsync(item.Item, ct);
                    }
                    if (msg.MessageType is SignalRMessageType.Completion
                        && msg is SignalRCompletionMessage completion
                        && receivesStreams.TryRemove(completion.InvocationId, out var c)
                        && openStreamInvocations.TryRemove(completion.InvocationId, out var responseId))
                    {
                        c.Writer.TryComplete();
                        await dto.SendCompletionItem(responseId, ct);
                    }

                    dto.AddMessage(msg);
                }
                message.SetLength(0);
            }
        }


        private static void Ping(WebSocket client, SignalRConnectionDto dto, CancellationToken cancellationToken) => Task.Run(async () =>
        {
            var timer = new PeriodicTimer(TimeSpan.FromSeconds(10));
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

        static IEnumerable<(SignalRMessage, string)> GetMessages(string json)
            => json.ParseFrame().Select(s => (Parse(s.Type, s.Json), s.Json));

        private static SignalRMessage Parse(SignalRMessageType type, string json) => (type) switch
        {
            SignalRMessageType.Invocation when (json.RootValueArray("streamIds") is null) => new SignalRInvocationMessage(json.RootValue("target"), json.RootValueArray("arguments")),
            SignalRMessageType.Invocation when (json.RootValueArray("streamIds") is not null) => new SignalRReceiveStreamInvocationMessage(json.RootValue("invocationId"), json.RootValue("target"), [], json.RootValueArray("streamIds")),
            SignalRMessageType.StreamItem => new SignalRStreamItemMessage(json.RootObjectValue("item"), json.RootValue("invocationId")),
            SignalRMessageType.StreamInvocation => new SignalRStreamInvokationMessage(json.RootValue("target"), json.RootValueArray("arguments"), json.RootValue("invocationId")),
            SignalRMessageType.Completion => new SignalRCompletionMessage(json.RootValue("invocationId")),
            SignalRMessageType.Close => new SignalRCloseMessage(error: json.RootValue("error")),
            SignalRMessageType.Ping => new SignalRPingMessage(),
            _ => new SignalRMessage(SignalRMessageType.None)
        };
    }
}
