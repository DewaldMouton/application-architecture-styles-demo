namespace Weather.VerticalSlice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register Dependencies

            var app = builder.Build();

            // Register Endpoints

            app.UseHttpsRedirection();

            app.Run();
        }
    }
}
