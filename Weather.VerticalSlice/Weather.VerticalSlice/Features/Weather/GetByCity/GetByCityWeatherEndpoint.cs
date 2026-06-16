using Weather.VerticalSlice.Features.Weather.GetByCity.Contracts;

namespace Weather.VerticalSlice.Features.Weather.GetByCity
{
    public class GetByCityWeatherEndpoint
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/weather/{city}", (string city, IGetByCityWeatherService weatherService) =>
                {
                    var result = weatherService.Get(city);
                    return Results.Ok(result);
                });
        }
    }
}
