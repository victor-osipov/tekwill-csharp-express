using System;
namespace WeatherMonitor.Worker.Domain
{
    /// <summary>
    /// Weather Info:
    ///     28*C = temperature
    ///     Chisinau = location
    ///     ...
    /// </summary>
    public class WeatherInfo
    {
        public double Temperature { get; set; }

        public string Location { get; set; }
    }
}
