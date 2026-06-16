using Weather.Layered.Models;
using Weather.Layered.Repositories.Contracts;
using Weather.Layered.Services.Contracts;

namespace Weather.Layered.Services
{
    public class WeatherService(IWeatherRepository weatherRepository) : IWeatherService
    {
        public WeatherForecast? Get(string city)
        {
            return weatherRepository.GetAll()
                .FirstOrDefault(weather => weather.City.Equals(city, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<WeatherForecast> GetAll()
        {
            return weatherRepository.GetAll();
        }
    }
}
