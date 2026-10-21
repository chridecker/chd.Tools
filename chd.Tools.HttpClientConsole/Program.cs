using chd.Tools.HttpClientConsole;
using Microsoft.Extensions.DependencyInjection;
using chd.Api.Base.Client.Extensions;
using chd.Api.Base.Contracts.Interfaces;

var cts = new CancellationTokenSource();

var services = new ServiceCollection();
services.AddHttpClient<TestClient>((sp) => new Uri("http://localhost:5601/").Append("testsub"));
services.AddTransient<TestClient>();
services.AddTransient<IApiKeyProvider, ApiKeyProvider>();

var sp = services.BuildServiceProvider();


var client = sp.GetRequiredService<TestClient>();



await client.PostAsync(cts.Token);
var lst = await client.GetAsync(cts.Token);


Console.WriteLine("Hello, World!");
