using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using blazorclient1.Models;
namespace blazorclient1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();
            ConfigurationServices(builder.Services); // Need for DI in WASAM
            await builder.Build().RunAsync();
        }

        // Need for DI in WASAM
        private static void ConfigurationServices(IServiceCollection services)
        {
            services.AddTransient<IFees,Fees>();
        }
    }
}
