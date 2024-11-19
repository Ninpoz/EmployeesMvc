using System.Net.Mail;
using Microsoft.EntityFrameworkCore;

namespace EmployeesMVC.Models;

public class DataService : IDataService
{
  private readonly ApplicationContext _context;
    public DataService(ApplicationContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Employee employee)
    {
        _context.Employees.Add(employee);
       await _context.SaveChangesAsync();
    }

    public async Task <Employee[]> GetAllAsync()
    {
      return await _context.Employees.Include(e => e.Company).ToArrayAsync();
    }

    public async Task<Employee> GetByIdAsync(int id)
    {
        return await _context.Employees.Include(e => e.Company).FirstOrDefaultAsync(e => e.Id == id);
    }
}
