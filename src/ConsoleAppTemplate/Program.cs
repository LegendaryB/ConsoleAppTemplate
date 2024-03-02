using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleAppTemplate
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);

            ConfigureServices(builder.Services);

            var host = builder.Build();
            var app = host.Services.GetRequiredService<App>();

            await app.RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Add your services

            services.AddSingleton<App>();
        }
    }
}
