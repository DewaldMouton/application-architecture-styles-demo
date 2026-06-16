using Weather.MinimalApi;
using Weather.VerticalSlice.Features.Weather.GetAll.Contracts;
using Weather.VerticalSlice.Models;

namespace Weather.VerticalSlice.Features.Weather.GetAll
{
    public class GetAllWeatherService : IGetAllWeatherService
    {
        public IEnumerable<WeatherForecast> GetAll()
        {
            return WeatherData.GetAll();
        }
    }
}
