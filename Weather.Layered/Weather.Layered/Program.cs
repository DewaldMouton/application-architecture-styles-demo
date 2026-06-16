
using Weather.Layered.Repositories;
using Weather.Layered.Repositories.Contracts;
using Weather.Layered.Services;
using Weather.Layered.Services.Contracts;

namespace Weather.Layered
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddTransient<IWeatherService, WeatherService>();
            builder.Services.AddSingleton<IWeatherRepository, WeatherRepository>();

            var app = builder.Build();

            app.UseHttpsRedirection();

            app.MapControllers();

            app.Run();
        }
    }
}
