using Weather.CleanArchitecture.Application.Managers.Contracts;
using Weather.CleanArchitecture.Domain.Models;
using Weather.CleanArchitecture.Infrastructure.Repositories.Contracts;

namespace Weather.CleanArchitecture.Application.Managers
{
    public class WeatherForecastManager(IWeatherForecastRepository weatherForecastRepository) : IWeatherForecastManager
    {
        public WeatherForecast? GetWeatherForecastByCity(string city)
        {
            return weatherForecastRepository.GetAll()
                .FirstOrDefault(x => x.City.Equals(city, StringComparison.CurrentCultureIgnoreCase));
        }

        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            return weatherForecastRepository.GetAll();
        }
    }
}
