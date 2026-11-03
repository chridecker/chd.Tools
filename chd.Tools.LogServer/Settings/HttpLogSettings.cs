using System.Net;

namespace chd.Tools.LogServer.Settings
{
    public class HttpLogSettings
    {
        public HttpStatusCode ResponseStatusCode { get; set; } = HttpStatusCode.OK;
        public string Response { get; set; } = string.Empty;
        public string ResponseContentType { get; set; } = "application/json";
        public bool UseSignalR { get; set; }
        public string ForwardUrl { get; set; }
    }
}
