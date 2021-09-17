using Blazor.Umbraco8.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Umbraco8
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            //Microsoft.Extensions.Http Nuget package.
            //Set up Typed client that accepts the HttpClient object
            //adds IHttpClientFactory to service collection
            //inject HttpClient through DI and dispose off safely.
            builder.Services.AddHttpClient<IProductService, ProductService>(client => client.BaseAddress = new Uri("https://localhost:44315/"));

            await builder.Build().RunAsync();
        }
    }
}
