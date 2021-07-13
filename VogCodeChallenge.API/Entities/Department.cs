using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        IEnumerable<Employee> Employees { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
