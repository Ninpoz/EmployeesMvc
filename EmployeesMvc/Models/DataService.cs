namespace EmployeesMvc.Models
{
    public class DataService
    {
        private static List<Employee> _employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Anna Andersson", Email = "anna.andersson@example.com" },
            new Employee { Id = 2, Name = "Bertil Berg", Email = "bertil.berg@example.com" },
            new Employee { Id = 3, Name = "Cecilia Carlsson", Email = "cecilia.carlsson@example.com" }
        };

        private int id = 3;
        public void Add(Employee employee)
        {
            employee.Id = ++id;
            _employees.Add(employee);

        }

        public Employee[] GetAll()
        {
            return _employees.ToArray();
        }

        public Employee GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
