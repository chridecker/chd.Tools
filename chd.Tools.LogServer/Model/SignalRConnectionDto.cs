using System.Net.WebSockets;

namespace chd.Tools.LogServer.Model
{
    public class SignalRConnectionDto : BaseCallDto
    {
        private List<SignalRMessage> _messages = [];
        public bool Connected { get; set; }
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
    }
}
