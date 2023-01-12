using AutoMapper;
using WCLManagement.Entities;
using WCLManagement.Infrastructure.Interfaces;
using WCLManagement.Repositories.Interfaces;

namespace WCLManagement.Repositories
{
    public class TimeSheetRepository : ITimeSheetRepository
    {
        private IRepository<TimeSheet, int> _timesheetRepository;
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public TimeSheetRepository(IRepository<TimeSheet, int> timesheetRepository, IUnitOfWork unitOfWork, IMapper mapper)
        { 
            _timesheetRepository = timesheetRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
