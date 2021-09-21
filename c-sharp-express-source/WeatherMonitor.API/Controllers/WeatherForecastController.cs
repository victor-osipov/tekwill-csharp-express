using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using WeatherMonitor.Domain.Service;

namespace WeatherMonitor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IWeatherService weatherService;

        public WeatherController(
            IWeatherService weatherService
            )
        {
            this.weatherService = weatherService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }



        [HttpGet]
        [Route("/test")]
        public IActionResult GetTestData()
        {
            var testObject = new
            {
                data = "test data",
                number = 100
            };

            Console.WriteLine($"Answering to /test . . ");

            return Ok(testObject);
        }


        [HttpGet]
        [Route("/getweather")]
        public IActionResult GetRandomWeatherData()
        {
            var weather = weatherService.GetCurrentWeather();

            Console.WriteLine($"Answering to /weather . . ");

            return Ok(weather);
        }
    }
}
