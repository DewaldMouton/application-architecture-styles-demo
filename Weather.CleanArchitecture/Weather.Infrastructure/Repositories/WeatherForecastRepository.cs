using Weather.CleanArchitecture.Domain.Models;
using Weather.CleanArchitecture.Infrastructure.Repositories.Contracts;

namespace Weather.CleanArchitecture.Infrastructure.Repositories
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        public List<WeatherForecast> GetAll() =>
        [
            new(){ City = "Utrecht", Date = DateTime.Now, TemperatureC = 12, Summary = "Cloudy" },
            new(){ City = "Amsterdam", Date = DateTime.Now, TemperatureC = 10, Summary = "Rain" },
        ];
    }
}
