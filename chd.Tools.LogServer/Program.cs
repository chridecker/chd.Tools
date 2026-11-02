using chd.Tools.LogServer;
using chd.Tools.LogServer.Extensions;
using chd.Tools.LogServer.Settings;
using chd.Base.Hosting.Extensions;
using WindowsFormsLifetime;
using chd.Tools.LogServer.Modules;

Thread.CurrentThread.SetApartmentState(ApartmentState.Unknown);
Thread.CurrentThread.SetApartmentState(ApartmentState.STA);

var setting = new HttpLogSettings();

var builder = Host.CreateApplicationBuilder(args);

//if (args.Length == 1 && int.TryParse(args[0], out var port))
//{
//    builder.WebHost.UseUrls($"http://*:{port}");
//}
//else if (args.All(a => int.TryParse(a, out _)))
//{
//    foreach (var p in args.Select(a => int.TryParse(a, out int p)))
//    {
//        builder.WebHost.UseUrls($"http://*:{p}");
//    }
//}
//else if (args.Any())
//{
//    builder.WebHost.UseUrls(args);
//}
//else
//{
//    builder.WebHost.UseUrls($"http://*:5601");
//}

builder.Logging.ClearProviders();

builder.Services.AddWindowsFormsLifetime<MainForm>();

builder.AddModuleManager(typeof(httpLogModule));

builder.Services.AddTools(setting);

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowLocalhost", policy =>
//    {
//        policy.SetIsOriginAllowed(_ => true)
//            .AllowAnyHeader()
//            .AllowAnyMethod()
//            .AllowCredentials(); // wichtig für SignalR
//    });
//});


var host = builder.Build();
//app.UseRouting();

//app.UseCors("AllowLocalhost");

//app.AddWebLogger();

host.Run();
