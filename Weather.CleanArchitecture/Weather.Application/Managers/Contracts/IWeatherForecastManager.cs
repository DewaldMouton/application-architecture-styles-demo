using Weather.CleanArchitecture.Domain.Models;

namespace Weather.CleanArchitecture.Application.Managers.Contracts
{
    public interface IWeatherForecastManager
    {
        WeatherForecast? GetWeatherForecastByCity(string city);

        IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}
