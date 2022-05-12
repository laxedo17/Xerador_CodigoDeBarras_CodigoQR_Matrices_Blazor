using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using Xerador_CodigoDeBarras_CodigoQR_Blazor;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//IgnoreScriptIsolation mellora o rendemento da app porque referencia o script externamente
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
