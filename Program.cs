using Island_Insights;
using Island_Insights.Models;
using Island_Insights.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http.Json;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var host = builder.Build();
var http = host.Services.GetRequiredService<HttpClient>();
var config = await http.GetFromJsonAsync<NewsDataApiSettings>("appsettings.json")
    ?? throw new InvalidOperationException("Failed to load NewsDataApiSettings from appsettings.json.");

builder.Services.AddSingleton(config);
builder.Services.AddScoped<INewsService, NewsService>();

await builder.Build().RunAsync();
