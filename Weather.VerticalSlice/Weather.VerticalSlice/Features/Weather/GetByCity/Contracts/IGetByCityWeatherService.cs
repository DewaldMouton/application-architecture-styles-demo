using Weather.VerticalSlice.Models;

namespace Weather.VerticalSlice.Features.Weather.GetByCity.Contracts
{
    public interface IGetByCityWeatherService
    {
        WeatherForecast? Get(string city);
    }
}
