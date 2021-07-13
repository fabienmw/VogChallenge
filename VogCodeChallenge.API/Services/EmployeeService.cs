using System;
using System.Collections.Generic;
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetAll()
        {
            return _dbProvider.GetEmployees();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<Employee> ListAll()
        {
            return _dbProvider.ListAll();
        }
    }
}
