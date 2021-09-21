using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using WeatherMonitor.Domain.Service;

namespace WeatherMonitor.Worker
{
    /// <summary>
    /// this is our worker!
    /// all logic about work is here;
    /// </summary>
    public class WeatherWorker : BackgroundService // == IHostedService
    {
        // props

        // methods

        //..

        /// <summary>
        /// logger object here!
        /// </summary>
        private readonly ILogger<WeatherWorker> _logger;
        private readonly IWeatherService weatherService;

        /// <summary>
        /// constructor of our worker!
        /// </summary>
        /// <param name="logger"></param>
        public WeatherWorker(
            ILogger<WeatherWorker> logger,
            IWeatherService weatherService
            )
        {
            _logger = logger;
            this.weatherService = weatherService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                var weather = weatherService.GetCurrentWeather();

                Console.WriteLine($"Weather: T={weather.temperature}, L={weather.location}");

                if (weather.temperature > 30)
                {
                    Console.WriteLine("Alert! Too hot..");
                }

                await Task.Delay(TimeSpan.FromSeconds(2));
            }
        }
    }
}
