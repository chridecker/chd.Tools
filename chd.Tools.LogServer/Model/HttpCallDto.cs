using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;

namespace chd.Tools.LogServer.Model
{
    public class HttpCallDto : BaseCallDto
    {
        public string Body { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public HttpStatusCode ResponseStatusCode { get; set; }
        public string ResponseStatusCodeText => $"{(int)ResponseStatusCode} - {ResponseStatusCode}";
        public string ResponseBody { get; set; }


        public override async Task Initialize(HttpContext context)
        {
            await base.Initialize(context);
            var basicAuth = GetBasicAuth(context);
            if (basicAuth.HasValue)
            {
                Username = basicAuth.Value.User;
                Password = basicAuth.Value.Password;
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
