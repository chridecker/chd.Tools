namespace chd.Tools.LogServer.Model
{
    public class SignalRSendClose(bool allowReconnect = true) : SignalRSendItem(SignalRMessageType.Close)
    {
        public bool AllowReconnect => allowReconnect;
    }
}
