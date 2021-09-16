
using WeatherMonitor.Worker.Domain;

namespace WeatherMonitor.Worker.Services
{
    /// <summary>
    /// Weather Service interface
    /// </summary>
    public interface IWeatherService
    {
        WeatherInfo GetCurrentWeather();
    }
}
