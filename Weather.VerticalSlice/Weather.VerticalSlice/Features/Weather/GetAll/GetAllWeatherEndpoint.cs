using Weather.VerticalSlice.Features.Weather.GetAll.Contracts;

namespace Weather.VerticalSlice.Features.Weather.GetAll
{
    public class GetAllWeatherEndpoint
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/weather", Handle);
        }

        private static IResult Handle(IGetAllWeatherService weatherService)
        {
            var result = weatherService.GetAll();
            return Results.Ok(result);
        }
    }
}
