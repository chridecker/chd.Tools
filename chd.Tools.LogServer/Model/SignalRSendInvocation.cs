namespace chd.Tools.LogServer.Model
{
    public class SignalRSendInvocation
    {
        public int Type { get; set; } = 1;
        public string Target { get; set; }
        public List<object> Arguments { get; set; } = [];

    }
}
