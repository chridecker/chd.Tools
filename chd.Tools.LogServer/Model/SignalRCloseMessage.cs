namespace chd.Tools.LogServer.Model
{
    public class SignalRCloseMessage(bool allowReconnect = true, string error = null) : SignalRMessage(SignalRMessageType.Close)
    {
        public bool AllowReconnect => allowReconnect;
        public string Error => error;

        public override string ToString() => $"Close: Reconnect {allowReconnect}, Error {error}";
    }
}
