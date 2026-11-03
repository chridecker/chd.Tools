using chd.Base.Hosting.Extensions;
using chd.Base.Hosting.Forms;
using chd.Tools.LogServer;
using chd.Tools.LogServer.Settings;
using chd.Tools.LogServer.Modules;
using chd.Tools.LogServer.Services;

Thread.CurrentThread.SetApartmentState(ApartmentState.Unknown);
Thread.CurrentThread.SetApartmentState(ApartmentState.STA);


var builder = DiFormHost.CreateApplicationBuilder<MainForm>(args);

builder.AddModuleManager().AddModule<HttpLogModule>();

builder.Services.AddSingleton<WebLoggerCache>();
builder.Services.AddSingleton<SignalRCache>();


builder.ConfigureDynamic<HttpLogSettings>();

var host = builder.Build();

host.Run();
