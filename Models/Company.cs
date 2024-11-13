using System.ComponentModel.DataAnnotations;

namespace EmployeesMVC.Models
{
    public class Company
    {

        public int CompanyId { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
