using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

using WeatherMonitor.Domain.Model;

namespace WeatherMonitor.Domain.Service
{
    public class RealWeatherService : IWeatherService
    {
        public RealWeatherService()
        {
        }

        public WeatherInfo GetCurrentWeather()
        {
            var httpClient = new HttpClient();

            var task = httpClient.GetAsync("https://localhost:15411/getweather");

            var content = task.Result.Content.ReadAsStringAsync().Result;

            var weater = JsonSerializer.Deserialize<WeatherInfo>(content);

            return weater;
        }
    }
}
