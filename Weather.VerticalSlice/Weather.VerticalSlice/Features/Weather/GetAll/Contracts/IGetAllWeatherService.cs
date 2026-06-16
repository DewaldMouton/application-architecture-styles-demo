using Weather.VerticalSlice.Models;

namespace Weather.VerticalSlice.Features.Weather.GetAll.Contracts
{
    public interface IGetAllWeatherService
    {
        IEnumerable<WeatherForecast> GetAll();
    }
}
