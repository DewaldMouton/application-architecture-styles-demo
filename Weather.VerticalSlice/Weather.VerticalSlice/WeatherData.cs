using Weather.VerticalSlice.Models;

namespace Weather.MinimalApi
{
    public static class WeatherData
    {
        public static List<WeatherForecast> GetAll() =>
        [
            new(){ City = "Utrecht", Date = DateTime.Now, TemperatureC = 12, Summary = "Cloudy" },
            new(){ City = "Amsterdam", Date = DateTime.Now, TemperatureC = 10, Summary = "Rain" },
        ];
    }
}
