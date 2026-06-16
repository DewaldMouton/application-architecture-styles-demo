using Weather.CleanArchitecture.Application.Managers;
using Weather.CleanArchitecture.Application.Managers.Contracts;
using Weather.CleanArchitecture.Infrastructure.Repositories;
using Weather.CleanArchitecture.Infrastructure.Repositories.Contracts;

namespace Weather.CleanArchitecture.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddTransient<IWeatherForecastManager, WeatherForecastManager>();
            builder.Services.AddSingleton<IWeatherForecastRepository, WeatherForecastRepository>();

            var app = builder.Build();

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
