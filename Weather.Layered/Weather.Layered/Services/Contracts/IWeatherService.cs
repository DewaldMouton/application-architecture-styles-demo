using Weather.Layered.Models;

namespace Weather.Layered.Services.Contracts
{
    public interface IWeatherService
    {
        WeatherForecast? Get(string city);

        IEnumerable<WeatherForecast> GetAll();
    }
}
