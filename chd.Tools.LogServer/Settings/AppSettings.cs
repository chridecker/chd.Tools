using System.Net;

namespace chd.Tools.LogServer.Settings
{
    public class AppSettings
    {
        public int MaxEntries { get; set; } = 100;
        public HttpStatusCode ResponseStatusCode { get; set; } = HttpStatusCode.OK;
        public string Response { get; set; } = string.Empty;

        public void Copy(AppSettings settings)
        {
            ResponseStatusCode = settings.ResponseStatusCode;
            MaxEntries = settings.MaxEntries;
            Response = settings.Response;
        }
    }
}
