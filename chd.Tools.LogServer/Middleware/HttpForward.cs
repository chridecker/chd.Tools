using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;

namespace chd.Tools.LogServer.Middleware
{
    public class HttpForward(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context, AppSettings settings, IHttpClientFactory httpClientFactory, CallLogger callLogger)
        {
            if (!string.IsNullOrWhiteSpace(settings.ForwardUrl))
            {
                var client = httpClientFactory.CreateClient();
                var targetUri = new Uri($"{settings.ForwardUrl}{context.Request.Path}{context.Request.QueryString}");

                using var requestMessage = new HttpRequestMessage(new HttpMethod(context.Request.Method), targetUri);

                foreach (var header in context.Request.Headers)
                {
                    if (!requestMessage.Headers.TryAddWithoutValidation(
                            header.Key,
                            header.Value.ToArray()))
                    {
                        requestMessage.Content ??= new StreamContent(context.Request.Body);

                        requestMessage.Content.Headers.TryAddWithoutValidation(
                            header.Key,
                            header.Value.ToArray());
                    }
                }

                // Body kopieren
                if (context.Request.ContentLength > 0)
                {
                    requestMessage.Content = new StreamContent(context.Request.Body);

                    if (!string.IsNullOrWhiteSpace(context.Request.ContentType))
                    {
                        requestMessage.Content.Headers.ContentType =
                            System.Net.Http.Headers.MediaTypeHeaderValue.Parse(
                                context.Request.ContentType);
                    }
                }

                using var responseMessage = await client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead, context.RequestAborted);

                // Status Code übernehmen
                context.Response.StatusCode = (int)responseMessage.StatusCode;

                // Response Headers übernehmen
                foreach (var header in responseMessage.Headers)
                {
                    context.Response.Headers[header.Key] = header.Value.ToArray();
                }

                foreach (var header in responseMessage.Content.Headers)
                {
                    context.Response.Headers[header.Key] = header.Value.ToArray();
                }

                context.Response.Headers.Remove("transfer-encoding");

                var json = await responseMessage.Content.ReadAsStringAsync();

                callLogger.CallResponse = json;

                await context.Response.WriteAsync(json);
                return;
            }

            await next(context);
        }
    }
}
