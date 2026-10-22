using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;

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
        public string Username { get; set; }
        public string Password { get; set; }
        public HttpStatusCode ResponseStatusCode { get; set; }
        public string ResponseStatusCodeText => $"{(int)ResponseStatusCode} - {ResponseStatusCode}";
        public string ResponseBody { get; set; }
        public string ForwardUrl { get; set; }

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

            var basicAuth = GetBasicAuth(context);
            if (basicAuth.HasValue)
            {
                Username = basicAuth.Value.User;
                Password = basicAuth.Value.Password;
            }

            foreach (var header in context.Request.Headers)
            {
                Headers[header.Key] = header.Value.ToString();
            }

            context.Request.EnableBuffering();
            using var reader = new StreamReader(context.Request.Body, Encoding.UTF8, detectEncodingFromByteOrderMarks: false, leaveOpen: true);
            Body = await reader.ReadToEndAsync(context.RequestAborted);
            context.Request.Body.Position = 0;
        }
        private static (string User, string Password)? GetBasicAuth(HttpContext context)
        {
            var authHeader = context.Request.Headers.Authorization.ToString();

            if (string.IsNullOrWhiteSpace(authHeader) ||
                !authHeader.StartsWith("Basic ", StringComparison.OrdinalIgnoreCase))
            {
                return null;
            }

            var encoded = authHeader["Basic ".Length..];

            var bytes = Convert.FromBase64String(encoded);
            var credentials = Encoding.UTF8.GetString(bytes);

            var parts = credentials.Split(':', 2);

            if (parts.Length != 2)
                return null;

            return (parts[0], parts[1]);
        }
    }
}
