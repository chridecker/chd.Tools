using NLog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace chd.Tools.LogServer.Model
{
    public class HttpCallDto
    {
        public DateTimeOffset DateTimeOffset { get; } = DateTimeOffset.Now;
        public string Method { get; set; }
        public string Path { get; set; }
        public string Query { get; set; }
        public string? ApiKey { get; set; }
        public string Host { get; set; }
        public string Body { get; set; }

        public Dictionary<string, string> Headers { get; } = [];

        public IPAddress RemoteIpAddress { get; set; }

        public async Task Initialize(HttpContext context)
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

            context.Request.EnableBuffering();
            using var reader = new StreamReader(context.Request.Body, Encoding.UTF8, detectEncodingFromByteOrderMarks: false, leaveOpen: true);
            Body = await reader.ReadToEndAsync(context.RequestAborted);
            context.Request.Body.Position = 0;
        }
    }
}
