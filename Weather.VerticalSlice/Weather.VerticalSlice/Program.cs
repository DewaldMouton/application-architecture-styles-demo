
using Weather.VerticalSlice.Features.Weather.GetAll;
using Weather.VerticalSlice.Features.Weather.GetAll.Contracts;
using Weather.VerticalSlice.Features.Weather.GetByCity;
using Weather.VerticalSlice.Features.Weather.GetByCity.Contracts;

namespace Weather.VerticalSlice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register Dependencies
            builder.Services.AddTransient<IGetByCityWeatherService, GetByCityWeatherService>();
            builder.Services.AddTransient<IGetAllWeatherService, GetAllWeatherService>();

            var app = builder.Build();

            // Register Endpoints
            GetByCityWeatherEndpoint.Map(app);
            GetAllWeatherEndpoint.Map(app);

            app.UseHttpsRedirection();

            app.Run();
        }
    }
}
