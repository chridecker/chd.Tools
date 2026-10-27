using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

namespace chd.Tools.LogServer.Model
{
    public class SignalRConnectionDto : BaseCallDto
    {
        private List<SignalRMessage> _messages = [];
        private WebSocket? _client;

        public event EventHandler MessageReceived;

        public bool Connected { get; set; }
        public bool CanSend => _client is not null && _client.State is WebSocketState.Open;

        public List<SignalRMessage> Messages => _messages.OrderByDescending(o => o.Time).ToList();
        public override async Task Initialize(HttpContext context)
        {
            await base.Initialize(context);
            foreach (var (p, i) in context.WebSockets.WebSocketRequestedProtocols.Select((s, i) => (s, i)))
            {
                Headers.Add($"WS Req Protocol {i + 1}", p);
            }
        }

        public void AddMessage(SignalRMessage message)
        {
            _messages.Add(message);
            MessageReceived?.Invoke(this, EventArgs.Empty);
        }

        public void SetClient(WebSocket client) => _client = client;

        public async Task SendStreamItem(string invocationId, object item, CancellationToken ct)
        {
            var data = new SignalRSendStreamItem(invocationId, item);
            var log = new SignalRStreamItemMessage(item, invocationId);
            await Send(data, log, ct);
        }
        public async Task SendCompletionItem(string invocationId, CancellationToken ct)
        {
            var data = new SignalRSendCompletion(invocationId);
            var log = new SignalRCompletionMessage( invocationId);
            await Send(data, log, ct);
        }


        public async Task SendMessage(string method, object[] arguments, CancellationToken ct)
        {
            var data = new SignalRSendInvocation(arguments, method);
            var log = new SignalRInvocationMessage(method, arguments.Select(s => JsonSerializer.Serialize(s, JsonSerializerOptions.Web)).ToArray());
            await Send(data, log, ct);
        }

        public async Task SendClose(CancellationToken ct)
        {
            var data = new SignalRSendClose();
            var log = new SignalRCloseMessage();
            await Send(data, log, ct);
        }

        private async Task Send<T>(T data, SignalRMessage log, CancellationToken ct)
            where T : SignalRSendItem
        {
            if (!CanSend) { return; }
            var json = JsonSerializer.Serialize(data, JsonSerializerOptions.Web);
            json += "\u001e";
            using var ms = new MemoryStream(Encoding.Default.GetBytes(json));
            await _client.SendAsync(ms.ToArray(), WebSocketMessageType.Text, WebSocketMessageFlags.EndOfMessage, ct);
            log.Data = json;
            log.Direction = "Send";
            log.Type = WebSocketMessageType.Text;
            this.AddMessage(log);
        }

    }
}
