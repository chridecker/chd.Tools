using Microsoft.AspNetCore.SignalR.Protocol;
using System.Diagnostics;
using System.Drawing.Text;
using System.Net.WebSockets;
using System.Text.Json;
using static chd.Tools.LogServer.Model.SignalRMessage;

namespace chd.Tools.LogServer.Model
{
    public class SignalRMessage(SignalRMessageType messageType)
    {
        public DateTimeOffset Time { get; set; } = DateTimeOffset.Now;
        public string Direction { get; set; }
        public string Data { get; set; }
        public string Value => this.ToString();
        public WebSocketMessageType Type { get; set; }
        public SignalRMessageType MessageType { get; } = messageType;
        public override string ToString() => "Basic Message";
    }

}
