using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WCLManagement.Interfaces;

namespace WCLManagement.Entities
{
    [Table("Departments")]
    public class Department : IDateTracking
    {
        [Key]
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int EmployeeID { get; set; }

        public virtual ICollection<Employee> Employees { set; get; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
