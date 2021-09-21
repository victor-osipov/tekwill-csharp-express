using System;
namespace WeatherMonitor.Domain.Model
{
    /// <summary>
    /// Weather Info:
    ///     28*C = temperature
    ///     Chisinau = location
    ///     ...
    /// </summary>
    public class WeatherInfo
    {
        public double temperature { get; set; }

        public string location { get; set; }
    }
}
