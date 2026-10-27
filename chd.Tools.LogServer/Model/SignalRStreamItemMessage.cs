namespace chd.Tools.LogServer.Model
{
    public class SignalRStreamItemMessage(object item, string invocationId) : SignalRMessage(SignalRMessageType.StreamItem)
    {
        public object Item => item;
        public string InvocationId => invocationId;

        public override string ToString()
            => $"Stream Item({invocationId}): Item {item}";
    }
}
