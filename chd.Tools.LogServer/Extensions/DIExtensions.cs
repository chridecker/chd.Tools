using chd.Tools.LogServer.Middleware;
using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;

namespace chd.Tools.LogServer.Extensions
{
    public static class DIExtensions
    {

        public static IServiceCollection AddTools(this IServiceCollection services, AppSettings settings)
        {
            services.AddScoped<CallLogger>();

            services.AddSingleton(settings);
            services.AddSingleton<WebLoggerCache>();

            services.AddHttpClient();

            return services;
        }
        public static IApplicationBuilder AddWebLogger(this IApplicationBuilder app)
        {
            app.UseWebSockets();

            app.UseMiddleware<WebLogger>();
            app.UseMiddleware<HttpForward>();
            app.UseMiddleware<SignalRForward>();
            return app;
        }
    }
}
