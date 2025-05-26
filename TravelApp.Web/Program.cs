using TravelApp.Web.Services;

namespace TravelApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<TravelService>();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllers();
            
            app.Run();
        }
    }
}
