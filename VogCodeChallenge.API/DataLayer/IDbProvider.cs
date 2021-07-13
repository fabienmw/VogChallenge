using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.DataLayer
{
    public interface IDbProvider
    {
        IEnumerable<Employee> GetEmployees();
        IList<Employee> ListAll();
    }
}
