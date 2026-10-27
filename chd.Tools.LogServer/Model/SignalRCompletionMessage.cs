namespace chd.Tools.LogServer.Model
{
    public class SignalRCompletionMessage(string invocationId) : SignalRMessage(SignalRMessageType.Completion)
    {
        public string InvocationId => invocationId;

        public override string ToString()
            => $"Completion ({invocationId})";
    }
}
