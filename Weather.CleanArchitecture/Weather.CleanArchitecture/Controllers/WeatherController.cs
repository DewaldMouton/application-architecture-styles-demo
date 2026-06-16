using Microsoft.AspNetCore.Mvc;
using Weather.CleanArchitecture.Api.Mappings;
using Weather.CleanArchitecture.Application.Managers.Contracts;

namespace Weather.CleanArchitecture.Api.Controllers
{
    [ApiController]
    [Route("weather")]
    public class WeatherController(IWeatherForecastManager weatherForecastManager) : ControllerBase
    {
        [HttpGet("{city}")]
        public IActionResult Get([FromRoute] string city)
        {
            var result = weatherForecastManager.GetWeatherForecastByCity(city);

            if (result is null)
            {
                return NotFound();
            }

            return Ok(WeatherForecastMapper.MapToWeatherForecastResponse(result));
        }

        [HttpGet]
        public IActionResult GetAll() =>
            Ok(WeatherForecastMapper.MapToWeatherForecastResponses(weatherForecastManager.GetWeatherForecasts()));
    }
}
