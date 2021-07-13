using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet("Employees")]
        public async Task<IActionResult> RetrieveAllEmployees()
        {
            var result = _employeeService.GetAll();
            return Ok(result);
        }

        [HttpGet("Employees/department/{departmentId}")]
        public async Task<IActionResult> RetrieveEmployeesByDepartment([FromRoute] int departmentId)
        {
            return Ok();
        }
    }
}
