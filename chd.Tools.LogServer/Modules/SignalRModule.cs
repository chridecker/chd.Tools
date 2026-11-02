using chd.Base.Hosting.Contracts.Settings;
using chd.Base.Hosting.Extensions;
using chd.Base.Hosting.Modules;
using chd.Tools.LogServer.Middleware;
using chd.Tools.LogServer.Services;
using Microsoft.Extensions.Options;

namespace chd.Tools.LogServer.Modules
{
    public class SignalRModule(IOptionsMonitor<WebModuleSettings> settings, SignalRCache signalRCache) : BaseWebModule(settings)
    {
        protected override void ConfigureModuleLogging(ILoggingBuilder logging, IServiceProvider appServices)
        {
            throw new NotImplementedException();
        }

        protected override void ConfigureModuleServices(IServiceCollection services, IServiceProvider appServices)
        {
            services.CopySingletonFromContainer<SignalRCache>(appServices);
        }

        protected override void ConfigureWebModule(WebApplication app)
        {
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
