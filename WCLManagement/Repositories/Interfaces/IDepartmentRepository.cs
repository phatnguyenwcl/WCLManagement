using WCLManagement.ViewModels;

namespace WCLManagement.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        Task CreateDepartmentAsync(DepartmentVM departmentVM);
    }
}
