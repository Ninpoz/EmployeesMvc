namespace EmployeesMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Stöd för controllers och views
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseStaticFiles();
            // Stöd för Route-attribut på våra Action-metoder
            app.MapControllers();
            app.Run();
        }
    }
}
