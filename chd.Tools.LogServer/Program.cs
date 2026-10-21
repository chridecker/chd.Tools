using chd.Api.Base.Extensions;
using chd.Tools.LogServer;
using chd.Tools.LogServer.Extensions;
using chd.Tools.LogServer.Settings;
using NLog.Layouts;
using NLog.Targets;
using NLog.Web;
using WindowsFormsLifetime;

Thread.CurrentThread.SetApartmentState(ApartmentState.Unknown);
Thread.CurrentThread.SetApartmentState(ApartmentState.STA);

var setting = new AppSettings();

var config = new NLog.Config.LoggingConfiguration();
config.Variables.Add("fileName", new Layout<string>("./Logs/Default_${shortdate}.log"));
config.AddTarget(new FileTarget()
{
    Name = "file",
    FileName = "${fileName}",
});

config.AddRule(NLog.LogLevel.Info, NLog.LogLevel.Error, "file");


var builder = WebApplication.CreateBuilder(args);

if (args.Any() && int.TryParse(args[0], out var port))
{
    builder.WebHost.UseUrls($"http://*:{port}");
}
else if (args.Any())
{
    builder.WebHost.UseUrls(args);
}
else
{
    builder.WebHost.UseUrls($"http://*:5601");
}

builder.Logging.ClearProviders();
builder.Logging.AddNLogWeb();

builder.Host.UseWindowsFormsLifetime<MainForm>();


builder.Services.AddTools(setting);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost", policy =>
    {
        policy.SetIsOriginAllowed(_ => true)
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials(); // wichtig für SignalR
    });
});


var app = builder.Build();
app.UseRouting();

app.UseCors("AllowLocalhost");

app.AddWebLogger();

app.Run();
