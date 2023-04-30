using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ZacharyKilburn_BlazorWASM;
using ZacharyKilburn_BlazorWASM.Data;
using ZacharyKilburn_BlazorWASM.Services;
using ZacharyKilburn_BlazorWASM.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<NavMenu>();
builder.Services.AddScoped<ProjectLoader>();

await builder.Build().RunAsync();
