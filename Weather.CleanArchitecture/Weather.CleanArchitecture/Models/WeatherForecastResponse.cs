namespace Weather.CleanArchitecture.Api.Models
{
    public class WeatherForecastResponse
    {
        public string City { get; set; } = null!;

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; } = null!;
    }
}
