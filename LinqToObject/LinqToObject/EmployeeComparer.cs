using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            return x.Name == y.Name && x.Gender == y.Gender && x.Age==y.Age;
        }

        public int GetHashCode(Employee obj)
        {
            return obj.Id;
        }
    }
}
