
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using WeatherMonitor.Domain.Service;

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

                    //services.AddTransient<IWeatherService, FakeWeatherService>();
                    services.AddTransient<IWeatherService, RealWeatherService>();

                    // add more services...

                    // ..
                });

            return host;
        }
    }
}
