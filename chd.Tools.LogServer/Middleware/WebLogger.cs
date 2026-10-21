using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Services;
using System.Net;
using System.Text;
using chd.Tools.LogServer.Settings;
using Microsoft.Extensions.Options;

namespace chd.Tools.LogServer.Middleware
{
    public class WebLogger(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context, WebLoggerCache cache, AppSettings settings)
        {
            var dto = new HttpCallDto();
            await dto.Initialize(context);
            dto.ResponseStatusCode = settings.ResponseStatusCode;
            dto.ResponseBody = settings.Response;
            context.Response.StatusCode = (int)settings.ResponseStatusCode;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(settings.Response);
            cache.Add(dto);
            await next(context);
        }
    }
}
