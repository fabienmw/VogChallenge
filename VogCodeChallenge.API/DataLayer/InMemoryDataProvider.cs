using System;
using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.DataLayer
{
    public class InMemoryDataProvider : IDbProvider
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return EmployeeTestData();
        }

        public IList<Employee> ListAll()
        {
            throw new NotImplementedException();
        }

        private List<Employee> EmployeeTestData()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Address = "",
                    FirstName = "John",
                    LastName = "Doe",
                    JobTitle = "Software Developer",
                    DepartmentId = 2
                },
                new Employee
                {
                    Id = 2,
                    Address = "",
                    FirstName = "Jane",
                    LastName = "Doe",
                    JobTitle = "UI/UX Manager",
                    DepartmentId = 2
                },
                new Employee
                {
                    Id = 3,
                    Address = "",
                    FirstName = "John",
                    LastName = "Smith",
                    JobTitle = "Scrum Master",
                    DepartmentId = 1
                }
            };
        }

        private List<Department> DepartmentTestData()
        {
            return new List<Department>
            {
                new Department
                {
                    Name = "IT",
                    Id = 1,
                    Address = "1 Sunset Avenue, Vancouver, BC"
                },
                new Department
                {
                    Name = "HR",
                    Id = 1,
                    Address = "304 Rivonia, Toronto, ON"
                }
            };
        }
    }
}
