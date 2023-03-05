namespace MvcViewsLayoutApp
{
    public interface ITimeService
    {
        string Time { set; get; }
    }

    public class LongTimeService : ITimeService
    {
        public string Time
        {
            set => Time = value;
            get => DateTime.Now.ToLongDateString();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<ITimeService, LongTimeService>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}