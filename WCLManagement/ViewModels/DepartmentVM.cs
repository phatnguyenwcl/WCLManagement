using WCLManagement.Entities;

namespace WCLManagement.ViewModels
{
    public class DepartmentVM
    {
        public string Name { get; set; }

        public int EmployeeID { get; set; }
        public virtual ICollection<Employee> Employees { set; get; }
    }
}
