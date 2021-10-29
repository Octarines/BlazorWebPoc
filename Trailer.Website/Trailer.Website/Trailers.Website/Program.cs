using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Trailers.Services;
using Trailers.Services.TrailerMovements;
using Trailers.Website;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient());
builder.Services.AddScoped<ITrailersService, TrailersService>();
builder.Services.AddScoped<ITrailerMovementsService, TrailerMovementsService>();

await builder.Build().RunAsync();
