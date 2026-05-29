
namespace Weather.MinimalApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            // Add routes

            app.UseHttpsRedirection();

            app.Run();
        }
    }
}
