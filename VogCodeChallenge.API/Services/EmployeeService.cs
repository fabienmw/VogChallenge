using System;
using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.API.DataLayer;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IDbProvider _dbProvider;
        public EmployeeService(IDbProvider dbProvider)
        {
            _dbProvider = dbProvider;
        }

        public IEnumerable<Employee> GetAll()
        {
            //Suggestion: Introduce a DTO or ViewModel and map only the fields that should be exposed rather than returning the result as is which expose the table or document structure

            return _dbProvider.GetEmployees();
        }

        public IList<Employee> ListAll()
        {
            return _dbProvider.ListAll();
        }

        public IEnumerable<Employee> RetrieveEmployeesByDepartment(int departmentId)
        {
            var employees = _dbProvider.GetEmployees();

            var employeesByDepartment = employees.Where(e => e.DepartmentId == departmentId);

            return employeesByDepartment;
        }
    }
}
