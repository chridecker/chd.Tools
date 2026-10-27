namespace chd.Tools.LogServer.Model
{
    public class SignalRSendCompletion(string invocationId): SignalRSendItem(SignalRMessageType.Completion)
    {
        public string InvocationId => invocationId;
    }
}
