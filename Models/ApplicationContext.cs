using Microsoft.EntityFrameworkCore;

namespace EmployeesMVC.Models
{
    public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company { CompanyId =1, Name = "Lucas Balsam AB"},
                new Company { CompanyId= 2, Name = "Mikaelas Minigrisar AB"},
                new Company { CompanyId = 3 , Name = "Antons Asfalt & Glass AB"}
                );
        }

    }
}
