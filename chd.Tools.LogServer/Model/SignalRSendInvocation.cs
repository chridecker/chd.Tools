namespace chd.Tools.LogServer.Model
{
    public class SignalRSendInvocation(object[] arguments, string target) : SignalRSendItem(SignalRMessageType.Invocation)
    {
        public object[] Arguments => arguments;
        public string Target => target;


    }
}
