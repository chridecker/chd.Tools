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
            services.AddSingleton(settings);
            services.AddSingleton<WebLoggerCache<HttpCallDto>>();

            return services;
        }
        public static IApplicationBuilder AddWebLogger(this IApplicationBuilder app)
        {
            app.UseMiddleware<WebLogger>();
            return app;
        }
    }
}
