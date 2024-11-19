using System.Net.Mail;
using EmployeesMVC.Models.ViewModels;
using Microsoft.EntityFrameworkCore;


namespace EmployeesMVC.Models;

public class DataService : IDataService
{
  private readonly ApplicationContext _context;
    public DataService(ApplicationContext context)
    {
        _context = context;
    }

    public async Task AddAsync(CreateVM createVM)
    {
      var company = await _context.Companys.FindAsync(createVM.CompanyId);
      var employee = new Employee()
      {
          Name = createVM.Name,
          Email = createVM.Email,

      };
        if (company != null)
        {
          employee.CompanyId = createVM.CompanyId;
        }
        _context.Employees.Add(employee);
        await _context.SaveChangesAsync();
    }

    public async Task <IndexVM[]> GetAllAsync()
    {
        return await _context.Employees
            .Select(e => new IndexVM
            {
               Name = e.Name,
               Email = e.Email,
               ShowAsHighlighted = e.Email.StartsWith("admin"),
               Id = e.Id,
            })
            .ToArrayAsync();
            

    }

    public async Task<Employee> GetByIdAsync(int id)
    {
        return await _context.Employees.Include(e => e.Company).FirstOrDefaultAsync(e => e.Id == id);
    }
}
