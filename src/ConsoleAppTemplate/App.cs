using Microsoft.Extensions.Logging;

namespace ConsoleAppTemplate
{
    internal class App
    {
        private readonly ILogger<App> _logger;

        public App(ILogger<App> logger)
        {
            _logger = logger;
        }

        public async Task RunAsync(CancellationToken cancellationToken = default)
        {

        }
    }
}
