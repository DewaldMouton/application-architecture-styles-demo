using Weather.CleanArchitecture.Api.Models;
using Weather.CleanArchitecture.Domain.Models;

namespace Weather.CleanArchitecture.Api.Mappings
{
    public static class WeatherForecastMapper
    {
        public static WeatherForecastResponse MapToWeatherForecastResponse(WeatherForecast weatherForecast) =>
            new()
            {
                City = weatherForecast.City,
                Date = weatherForecast.Date,
                TemperatureC = weatherForecast.TemperatureC,
                Summary = weatherForecast.Summary,
            };

        public static IEnumerable<WeatherForecastResponse> MapToWeatherForecastResponses(IEnumerable<WeatherForecast> weatherForecasts) =>
            weatherForecasts.Select(MapToWeatherForecastResponse);
    }
}
