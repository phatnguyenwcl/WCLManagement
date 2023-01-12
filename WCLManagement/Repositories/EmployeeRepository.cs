using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WCLManagement.EF;
using WCLManagement.Entities;
using WCLManagement.Infrastructure.Interfaces;
using WCLManagement.Repositories.Interfaces;
using WCLManagement.ViewModels;

namespace WCLManagement.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private IRepository<Employee, int> _employeeRepository;
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
    
        public EmployeeRepository(IRepository<Employee, int> employeeRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        public async Task CreateEmployeeAsync(EmployeeVM employeeVm)
        {
            if (employeeVm == null)
            {
                throw new ArgumentNullException(nameof(employeeVm));
            }
            var employeeObj = _mapper.Map<EmployeeVM, Employee>(employeeVm);
        }
    }
}
