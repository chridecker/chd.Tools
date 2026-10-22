using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Services;
using System.Net;
using System.Text;
using chd.Tools.LogServer.Settings;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;

namespace chd.Tools.LogServer.Middleware
{
    public class WebLogger(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context, WebLoggerCache cache, AppSettings settings, CallLogger callLogger)
        {
            var dto = new HttpCallDto();
            await dto.Initialize(context);
            if (string.IsNullOrWhiteSpace(settings.ForwardUrl)
                && !context.WebSockets.IsWebSocketRequest
                && !IsSignalRRequest(context, settings))
            {
                context.Response.StatusCode = (int)settings.ResponseStatusCode;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(settings.Response, context.RequestAborted);
                dto.ResponseStatusCode = settings.ResponseStatusCode;
                dto.ResponseBody = settings.Response;
                cache.Add(dto);
                return;
            }

            dto.ForwardUrl = settings.ForwardUrl;
            dto.IsWebSocket = context.WebSockets.IsWebSocketRequest;
            cache.Add(dto);

            await next(context);
            dto.ResponseStatusCode = (HttpStatusCode)context.Response.StatusCode;
            dto.ResponseBody = callLogger.CallResponse;
            cache.UpdateData();
        }

        private bool IsSignalRRequest(HttpContext context, AppSettings settings)
            => settings.UseSignalR
                 && context.Request is { Method: "POST", Path.HasValue: true } 
                 && context.Request.Path.Value.EndsWith("negotiate");

    }
}
