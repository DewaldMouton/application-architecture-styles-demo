using Weather.MinimalApi;

namespace Weather.Fluent.Extensions
{
    public static class WeatherEndpointExtensions
    {
        public static RouteGroupBuilder MapWeather(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/weather");

            group.MapGet("/", GetAll)
                .WithLogging()
                .WithMetadata("GetAllWeather");

            group.MapGet("/{city}", GetByCity)
                .WithLogging()
                .WithMetadata("GetWeatherByCity"); ;

            return group;
        }

        private static IResult GetAll()
        {
            return Results.Ok(WeatherData.GetAll());
        }

        private static IResult GetByCity(string city)
        {
            var result = WeatherData.GetAll().FirstOrDefault(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase));

            return result is not null
                ? Results.Ok(result)
                : Results.NotFound();
        }
    }
}
