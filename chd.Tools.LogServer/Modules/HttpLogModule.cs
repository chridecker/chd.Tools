using chd.Base.Hosting.Contracts.Settings;
using chd.Base.Hosting.Extensions;
using chd.Base.Hosting.Modules;
using chd.Tools.LogServer.Middleware;
using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;
using Microsoft.Extensions.Options;

namespace chd.Tools.LogServer.Modules
{
    public class HttpLogModule(IOptionsMonitor<WebModuleSettings> optionsMonitor, SignalRCache signalRCache) : BaseWebModule<WebModuleSettings>(optionsMonitor)
    {
        protected override void ConfigureModuleLogging(ILoggingBuilder logging, IServiceProvider appServices)
        {

        }

        protected override void ConfigureModuleServices(IServiceCollection services, IConfiguration configuration, IServiceProvider appServices)
        {
            services.AddHttpClient();
            services.Configure<HttpLogSettings>(configuration.GetSection(nameof(HttpLogSettings)));
            services.AddScoped<CallLogger>();
            services.CopySingletonFromContainer<WebLoggerCache>(appServices);
            services.CopySingletonFromContainer<SignalRCache>(appServices);
        }

        protected override void ConfigureWebModule(WebApplication app)
        {
            app.UseMiddleware<WebLogger>();
            app.UseMiddleware<HttpForward>();

            app.UseWebSockets();

            app.UseMiddleware<SignalRForward>();
            app.UseMiddleware<SignalRSelf>();
        }

        public override async Task StopModuleAsync(CancellationToken cancellationToken = default)
        {
            foreach (var dto in signalRCache.Data.Where(x => x.Connected))
            {
                await dto.SendClose(CancellationToken.None);
            }
            await base.StopModuleAsync(cancellationToken);
        }
    }
}
