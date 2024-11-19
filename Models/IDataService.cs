using EmployeesMVC.Models.ViewModels;

namespace EmployeesMVC.Models
{
    public interface IDataService
    {
        Task<IndexVM[]>GetAllAsync();

        Task<Employee> GetByIdAsync(int id);

        Task AddAsync(CreateVM createVM);
    }
}
