
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using WeatherMonitor.Worker.Services;

namespace WeatherMonitor.Worker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Create(args)
                .Build()
                .Run();
        }

        public static IHostBuilder Create(string[] args)
        {
            var host = Host
                .CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<WeatherWorker>();

                    services.AddTransient<IWeatherService, FakeWeatherService>();

                    // add more services...

                    // ..
                });

            return host;
        }
    }
}
