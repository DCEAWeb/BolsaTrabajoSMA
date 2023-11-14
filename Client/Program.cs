//using BolsaTrabajoSMA.Client;
//using Microsoft.AspNetCore.Components.Web;
//using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

//var builder = WebAssemblyHostBuilder.CreateDefault(args);
//builder.RootComponents.Add<App>("#app");
//builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//await builder.Build().RunAsync();

using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BolsaTrabajoSMA.Client;
using BolsaTrabajoSMA.Client.Auth;
using BolsaTrabajoSMA.Client.Auth;
using BolsaTrabajoSMA.Client;
using BolsaTraSMA.Client.Auth;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ProveedorAutenticacion>();

builder.Services.AddScoped<AuthenticationStateProvider, ProveedorAutenticacion>(proveedor =>
proveedor.GetRequiredService<ProveedorAutenticacion>());

builder.Services.AddScoped<ILoginService, ProveedorAutenticacion>(proveedor =>
proveedor.GetRequiredService<ProveedorAutenticacion>());

await builder.Build().RunAsync();
