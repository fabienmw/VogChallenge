using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/")]
    [ApiController]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet("Employees")]
        public IActionResult RetrieveAllEmployees()
        {
            var result = _employeeService.GetAll();
            return Ok(result);
        }

        [HttpGet("Employees/department/{departmentId}")]
        public IActionResult RetrieveEmployeesByDepartment([FromRoute] int departmentId)
        {
            var result = _employeeService.ListAll();
            return Ok(result);
        }
    }
}
