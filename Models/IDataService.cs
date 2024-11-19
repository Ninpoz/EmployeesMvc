namespace EmployeesMVC.Models
{
    public interface IDataService
    {
        Task<Employee[]>GetAllAsync();

        Task<Employee> GetByIdAsync(int id);

        Task AddAsync(Employee employee);
    }
}
