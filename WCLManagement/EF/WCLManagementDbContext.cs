using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WCLManagement.Entities;

namespace WCLManagement.EF
{
    public class WCLManagementDbContext : DbContext
    {
        public WCLManagementDbContext(DbContextOptions<WCLManagementDbContext> context) : base(context) { }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<TimeSheet> TimeSheets { get; set; }
    }
}
