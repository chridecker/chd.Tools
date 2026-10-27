namespace chd.Tools.LogServer.Model
{
    public class SignalRSendStreamItem(string invocationId, object item) : SignalRSendItem(SignalRMessageType.StreamItem)
    {
        public string InvocationId => invocationId;
        public object Item => item;
    }



}
