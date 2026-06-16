
namespace Weather.MinimalApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            BuildRoutes(app);

            app.UseHttpsRedirection();

            app.Run();
        }

        private static void BuildRoutes(WebApplication app)
        {
            app.MapGet("/weather", () =>
            {
                return WeatherData.GetAll();
            });

            app.MapGet("/weather/{city}", (string city) => {
                return WeatherData.GetAll().Where(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase));
            });
        }
    }
}
