using System.ComponentModel.DataAnnotations;


namespace EmployeesMVC.Models;

public class Employee
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public int? CompanyId { get; set; }
    public Company? Company { get; set; }

}
