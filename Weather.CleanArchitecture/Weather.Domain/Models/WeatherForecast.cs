namespace Weather.CleanArchitecture.Domain.Models
{
    public class WeatherForecast
    {
        public string City { get; set; } = null!;

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; } = null!;
    }
}
