using System.Net.Mail;
using Microsoft.EntityFrameworkCore;

namespace EmployeesMVC.Models;

public class DataService : IDataService
{
    //private List<Employee> applicationContext = 
    //    [
    //    new Employee { Id = 1, Name = "Bo Ek", Email = "bo.ek@email.com"},
    //    new Employee { Id = 2, Name = "Eva Boo", Email = "eva.boo@email.com"},
    //    new Employee { Id = 3, Name = "Ludo Hansi", Email = "ludo.hansi@email.com"},
    //    new Employee { Id = 3, Name = "Leena Holzt", Email = "leena.holzt@email.com"}
    //    ];

    //int id;

  private readonly ApplicationContext _context;
    public DataService(ApplicationContext context)
    {
        _context = context;
    }

    public void Add(Employee employee)
    {
        _context.Employees.Add(employee);
        _context.SaveChanges();
    }

    public Employee[] GetAll()
    {
      return _context.Employees.Include(e => e.Company).ToArray();
    }

    public Employee GetById(int id)
    {
        return _context.Employees.Include(e => e.Company).FirstOrDefault(e => e.Id == id);
    }
}
