using AutoMapper;
using WCLManagement.Entities;
using WCLManagement.ViewModels;

namespace WCLManagement.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentVM>();
            CreateMap<Employee, EmployeeVM>();
            CreateMap<TimeSheet, TimeSheetVM>();
        }
    }
}
