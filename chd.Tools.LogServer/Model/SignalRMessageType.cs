namespace chd.Tools.LogServer.Model
{
    public enum SignalRMessageType
    {
        None = 0,
        Invocation = 1,
        StreamItem = 2,
        Completion = 3,
        StreamInvocation = 4,
        CancelInvocation = 5,
        Ping = 6,
        Close = 7,
        Ack = 8,
        Sequence = 9,
        HandshakeRequest = 100,
        HandshakeResponse = 101,

    }
}
