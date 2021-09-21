using System;

using WeatherMonitor.Domain.Model;

namespace WeatherMonitor.Domain.Service
{
    /// <summary>
    /// Weather Service interface
    /// </summary>
    public interface IWeatherService
    {
        WeatherInfo GetCurrentWeather();
    }


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
                location = "fake",
                temperature = random.NextDouble() * 100
            };

            return fake;
        }
    }
}
