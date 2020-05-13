using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToObject
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DeptId { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public enum Gender
    {
        Male,Female
    }
}
