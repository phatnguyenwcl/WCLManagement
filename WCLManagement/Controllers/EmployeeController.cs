using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WCLManagement.Entities;
using WCLManagement.Repositories.Interfaces;
using WCLManagement.ViewModels;

namespace WCLManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

       
    }
}
