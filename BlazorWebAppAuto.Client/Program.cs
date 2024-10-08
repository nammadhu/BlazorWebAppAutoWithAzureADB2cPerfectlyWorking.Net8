using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWebAppAuto.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddHttpClient("TestAPI", client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});
builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();
await builder.Build().RunAsync();
