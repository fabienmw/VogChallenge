using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.DataLayer
{
    public class SQLDbProvider : IDbProvider
    {
        //NOTE: here you can make use of EF core or Dapper as your ORM and implement the below methods.
        public IEnumerable<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public IList<Employee> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
