using Microsoft.AspNetCore.Mvc;
using Weather.Layered.Services.Contracts;

namespace Weather.Layered.Controllers
{
    [ApiController]
    [Route("weather")]
    public class WeatherController(IWeatherService weatherService) : ControllerBase
    {
        [HttpGet("{city}")]
        public IActionResult Get([FromRoute] string city)
        {
            var result = weatherService.Get(city);

            if (result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll() =>
            Ok(weatherService.GetAll());
    }
}
