using Weather.CleanArchitecture.Domain.Models;

namespace Weather.CleanArchitecture.Infrastructure.Repositories.Contracts
{
    public interface IWeatherForecastRepository
    {
        List<WeatherForecast> GetAll();
    }
}
