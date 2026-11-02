using chd.Base.Hosting.Contracts.Settings;
using chd.Base.Hosting.Extensions;
using chd.Base.Hosting.Modules;
using chd.Tools.LogServer.Extensions;
using chd.Tools.LogServer.Middleware;
using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;
using Microsoft.Extensions.Options;

namespace chd.Tools.LogServer.Modules
{
    public class httpLogModule(IOptionsMonitor<WebModuleSettings> optionsMonitor) : BaseWebModule(optionsMonitor)
    {
        protected override void ConfigureModuleLogging(ILoggingBuilder logging, IServiceProvider appServices)
        {

        }

        protected override void ConfigureModuleServices(IServiceCollection services, IServiceProvider appServices)
        {
            services.AddScoped<CallLogger>();
            services.CopySingletonFromContainer<HttpLogSettings>(appServices);
            services.CopySingletonFromContainer<WebLoggerCache>(appServices);

            services.AddHttpClient();
        }

        protected override void ConfigureWebModule(WebApplication app)
        {
            app.UseMiddleware<WebLogger>();
            app.UseMiddleware<HttpForward>();
        }
    }
}
