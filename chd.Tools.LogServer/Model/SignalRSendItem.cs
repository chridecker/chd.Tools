namespace chd.Tools.LogServer.Model
{
    public abstract class SignalRSendItem(SignalRMessageType type)
    {
        public int Type { get; set; } = (int)type;
    }
}
