namespace Weather.Fluent.Extensions
{
    public static class EndpointFluentExtensions
    {
        public static RouteHandlerBuilder WithLogging(this RouteHandlerBuilder builder)
        {
            return builder.AddEndpointFilter(async (context, next) =>
            {
                Console.WriteLine($"Request: {context.HttpContext.Request.Path}");
                return await next(context);
            });
        }

        public static RouteHandlerBuilder WithMetadata(this RouteHandlerBuilder builder, string name)
        {
            return builder.WithName(name)
                .WithSummary($"Endpoint: {name}");
        }

    }
}
