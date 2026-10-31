using System.Net;
using System.Text;

namespace chd.Tools.LogServer.Model
{
    public abstract class BaseCallDto
    {
        public string Host { get; set; }
        public string? ApiKey { get; set; }
        public string ForwardUrl { get; set; }
        public bool IsWebSocket { get; set; }
        public string Method { get; set; }
        public DateTimeOffset DateTimeOffset { get; } = DateTimeOffset.Now;
        public string Path { get; set; }
        public string Query { get; set; }
        public Dictionary<string, string> Headers { get; } = [];
        public IPAddress RemoteIpAddress { get; set; }


        public virtual async Task Initialize(HttpContext context)
        {
            RemoteIpAddress = context.Connection.RemoteIpAddress;

            if (RemoteIpAddress is not null)
            {
                try
                {
                    var hostEntry = Dns.GetHostEntryAsync(RemoteIpAddress);
                    await Task.WhenAny(hostEntry, Task.Delay(50));

                    Host = hostEntry.IsCompletedSuccessfully ? hostEntry.Result.HostName : "Not resolved";
                }catch{}
            }
            ApiKey = context.Request.Headers.TryGetValue("x-api-key", out var key) ? key.ToString() : string.Empty;
            Method = context.Request.Method;
            Path = context.Request.Path;
            Query = context.Request.QueryString.ToString();

            foreach (var header in context.Request.Headers)
            {
                Headers[header.Key] = header.Value.ToString();
            }
        }
    }
}
