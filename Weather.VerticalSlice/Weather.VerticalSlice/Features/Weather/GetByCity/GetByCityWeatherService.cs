using Weather.MinimalApi;
using Weather.VerticalSlice.Features.Weather.GetByCity.Contracts;
using Weather.VerticalSlice.Models;

namespace Weather.VerticalSlice.Features.Weather.GetByCity
{
    public class GetByCityWeatherService : IGetByCityWeatherService
    {
        public WeatherForecast? Get(string city)
        {
            return WeatherData.GetAll()
                .FirstOrDefault(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase));
        }
    }
}
