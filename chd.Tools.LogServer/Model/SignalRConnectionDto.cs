using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

namespace chd.Tools.LogServer.Model
{
    public class SignalRConnectionDto : BaseCallDto
    {
        private List<SignalRMessage> _messages = [];
        private WebSocket? _client;

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
        }

        public void SetClient(WebSocket client) => _client = client;

        public async Task SendMessage(string method, object[] arguments, CancellationToken ct)
        {
            if (!CanSend) { return; }

            var data = new SignalRSendInvocation()
            {
                Target = method
            };
            data.Arguments.AddRange(arguments);
            var json = JsonSerializer.Serialize(data, JsonSerializerOptions.Web);
            json += "\u001e";
            using var ms = new MemoryStream(Encoding.Default.GetBytes(json));
            await _client.SendAsync(ms.ToArray(), WebSocketMessageType.Text, WebSocketMessageFlags.EndOfMessage, ct);
            var dto = new SignalRInvocationMessage(method, arguments.Select(s => JsonSerializer.Serialize(s, JsonSerializerOptions.Web)).ToArray());
            dto.Data = json;
            dto.Direction = "Send";
            dto.Type = WebSocketMessageType.Text;
            this.AddMessage(dto);
        }
    }
}
