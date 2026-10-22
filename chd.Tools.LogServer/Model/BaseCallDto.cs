using System.Net;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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
                var hostEntry = await Dns.GetHostEntryAsync(RemoteIpAddress);
                Host = hostEntry.HostName;
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
