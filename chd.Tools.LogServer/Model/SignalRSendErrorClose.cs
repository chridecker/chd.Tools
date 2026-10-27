namespace chd.Tools.LogServer.Model
{
    public class SignalRErrorSendClose(bool allowReconnect = true, string error = "") : SignalRSendClose(allowReconnect)
    {
        public string Error => error;
    }
}
