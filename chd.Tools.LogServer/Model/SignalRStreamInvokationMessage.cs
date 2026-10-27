namespace chd.Tools.LogServer.Model
{
    public class SignalRStreamInvokationMessage(string method, string[] arguments, string invocationId) : SignalRMessage(SignalRMessageType.StreamInvocation)
    {
        public string Method => method;
        public string[] Arguments => arguments;
        public string InvocationId => invocationId;



        public override string ToString()
            => $"Stream Invocation({invocationId}): {method}, Args {arguments.Length}";
    }
}
