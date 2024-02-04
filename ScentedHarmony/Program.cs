using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ScentedHarmony;
using MudBlazor.Services;
using ScentedHarmony.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var shoppingCartService = new ShoppingCartService();
builder.Services.AddSingleton<IShoppingCartService>(shoppingCartService);
builder.Services.AddSingleton<IShoppingCartState>(shoppingCartService);

builder.Services.AddSingleton<IProductService, ProductsService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();

await builder.Build().RunAsync();