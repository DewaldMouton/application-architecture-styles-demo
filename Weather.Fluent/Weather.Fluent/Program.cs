using Weather.MinimalApi;

namespace Weather.Fluent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            app.MapGet("/weather", () =>
            {
                return WeatherData.GetAll();
            });

            app.MapGet("/weather/{city}", (string city) => {
                return WeatherData.GetAll().Where(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase));
            });

            app.UseHttpsRedirection();

            app.Run();
        }
    }
}
