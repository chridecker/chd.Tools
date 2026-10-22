using System.Text.Json;

namespace chd.Tools.LogServer.Model
{
    public class SignalRInvocationMessage(string method, string[] arguments) : SignalRMessage(SignalRMessageType.Invocation)
    {
        public string Method => method;
        public string[] Arguments => arguments;

        public override string ToString()
            => $"Invocation: {method}, Args {arguments.Length}";
    }
}
