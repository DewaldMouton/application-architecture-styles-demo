using Weather.Layered.Models;
using Weather.Layered.Repositories.Contracts;

namespace Weather.Layered.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        public List<WeatherForecast> GetAll() =>
        [
            new(){ City = "Utrecht", Date = DateTime.Now, TemperatureC = 12, Summary = "Cloudy" },
            new(){ City = "Amsterdam", Date = DateTime.Now, TemperatureC = 10, Summary = "Rain" },
        ];
    }
}
