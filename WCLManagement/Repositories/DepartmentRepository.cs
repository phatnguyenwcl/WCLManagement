using AutoMapper;
using WCLManagement.Entities;
using WCLManagement.Infrastructure.Interfaces;
using WCLManagement.Repositories.Interfaces;
using WCLManagement.ViewModels;

namespace WCLManagement.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private IRepository<Department, int> _departmentRepository;
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentRepository(IRepository<Department, int> departmentRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateDepartmentAsync(DepartmentVM departmentVM)
        {
            if (departmentVM == null)
            {
                throw new ArgumentNullException(nameof(departmentVM));
            }
            var department = _mapper.Map<DepartmentVM, Department>(departmentVM);
            _departmentRepository.Add(department);
        }
    }
}
