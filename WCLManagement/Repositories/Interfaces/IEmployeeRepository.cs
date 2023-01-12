using WCLManagement.ViewModels;

namespace WCLManagement.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        //Task<IEnumerable<EmployeeVM>> GetEmployeesAsync();
        //Task<EmployeeVM> GetEmployeeAsync(int id);
        Task CreateEmployeeAsync(EmployeeVM employee);
        //Task UpdateEmployeeAsync(EmployeeVM employee);
        //Task DeleteEmployeeAsync(int id);
    }
}
