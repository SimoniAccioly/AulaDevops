using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace AulaDevops.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public WeatherForecastController()
        {
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        
        [HttpPost(Name = "PostWeatherForecast")]
        [ExcludeFromCodeCoverage]
        public WeatherForecast Post()
        {
            var count = 0;

            return new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = Random.Shared.Next(-20, 55) / count,
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };
        }
    }
}