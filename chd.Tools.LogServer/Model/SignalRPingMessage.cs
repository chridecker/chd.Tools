namespace chd.Tools.LogServer.Model
{
    public class SignalRPingMessage() : SignalRMessage(SignalRMessageType.Ping)
    {
        public override string ToString() => "Ping";
    }
}
