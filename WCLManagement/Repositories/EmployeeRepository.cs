using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WCLManagement.EF;
using WCLManagement.Entities;
using WCLManagement.Repositories.Interfaces;
using WCLManagement.ViewModels;

namespace WCLManagement.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly WCLManagementDbContext _context;
        private readonly IMapper _mapper;

        public EmployeeRepository(WCLManagementDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<EmployeeVM>> GetEmployeesAsync()
        {
            var lstEmployees = await _context.Employees.ToListAsync();

            var result = _mapper.Map<List<Employee>, List<EmployeeVM>>(lstEmployees);

            return result;
        }

        public async Task<EmployeeVM> GetEmployeeAsync(int id)
        {
            if (id == 0) return new EmployeeVM();

            var employee = await _context.Employees.FindAsync(id);

            if (employee == null)
            {
                return new EmployeeVM();
            }

            var result = _mapper.Map<Employee, EmployeeVM>(employee);

            return result;
        }

        public Task CreateEmployeeAsync(EmployeeVM employee)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeeAsync(EmployeeVM employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeeAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
