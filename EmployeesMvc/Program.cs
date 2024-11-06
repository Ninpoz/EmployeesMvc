namespace EmployeesMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // St�d f�r controllers och views
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseStaticFiles();
            // St�d f�r Route-attribut p� v�ra Action-metoder
            app.MapControllers();
            app.Run();
        }
    }
}
