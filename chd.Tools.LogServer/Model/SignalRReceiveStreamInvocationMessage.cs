using System.Text.Json;

namespace chd.Tools.LogServer.Model
{
    public class SignalRReceiveStreamInvocationMessage(string invocationId, string method, string[] arguments, string[] streams) : SignalRInvocationMessage(method, arguments)
    {
        public string InvocationId => invocationId;
        public string[] Streams => streams;
        public override string ToString()
            => $"Receive Stream Invocation({invocationId}): {method}, Streams {streams.Length}";
    }
}
