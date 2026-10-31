using chd.Tools.LogServer;
using chd.Tools.LogServer.Extensions;
using chd.Tools.LogServer.Settings;
using WindowsFormsLifetime;

Thread.CurrentThread.SetApartmentState(ApartmentState.Unknown);
Thread.CurrentThread.SetApartmentState(ApartmentState.STA);

var setting = new AppSettings();

var builder = WebApplication.CreateBuilder(args);

if (args.Length == 1 && int.TryParse(args[0], out var port))
{
    builder.WebHost.UseUrls($"http://*:{port}");
}
else if (args.All(a => int.TryParse(a, out _)))
{
    foreach (var p in args.Select(a => int.TryParse(a, out int p)))
    {
        builder.WebHost.UseUrls($"http://*:{p}");
    }
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
