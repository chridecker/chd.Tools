using chd.Tools.LogServer.Middleware;
using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;

namespace chd.Tools.LogServer.Extensions
{
    public static class DIExtensions
    {

        public static IServiceCollection AddTools(this IServiceCollection services, HttpLogSettings settings)
        {
            services.AddScoped<CallLogger>();

            services.AddSingleton(settings);
            services.AddSingleton<WebLoggerCache>();
            services.AddSingleton<SignalRCache>();

            services.AddHttpClient();

            return services;
        }
    }
}
