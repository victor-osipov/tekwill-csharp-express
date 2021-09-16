using System;

using WeatherMonitor.Worker.Domain;

namespace WeatherMonitor.Worker.Services
{
    public class FakeWeatherService : IWeatherService
    {
        public FakeWeatherService()
        {
        }

        public WeatherInfo GetCurrentWeather()
        {
            var random = new Random();

            var fake = new WeatherInfo
            {
                Location = "fake",
                Temperature = random.NextDouble() * 100
            };

            return fake;
        }
    }
}
