using EmployeesMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<IDataService, DataService>();
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationContext>(d => d.UseSqlServer(connectionString));
            //builder.Services.AddSingleton<IDataService, DataService>();
            //builder.Services.AddSingleton<IDataService, AnotherDataService>();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();
        }
    }
}
