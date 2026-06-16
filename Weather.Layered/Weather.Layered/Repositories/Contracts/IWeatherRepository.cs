using Weather.Layered.Models;

namespace Weather.Layered.Repositories.Contracts
{
    public interface IWeatherRepository
    {
        List<WeatherForecast> GetAll();
    }
}
