using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////// 1
            List<int> intlist = new List<int> { 5, 3, 45, 89, 8, 9, 81, 72, 3, 88, 1 };
            #region part1

            //a
            //var res = intlist.Where(i => i % 2 == 0).ToList();
            //res.ForEach(i => Console.WriteLine(i));

            //b
            //var res = intlist.OrderByDescending(i=>i).ToList();
            //res.ForEach(i => Console.WriteLine(i));

            //c
            //List<int> intlist2 = new List<int> { 72, 8, 12, 89, 84 };
            //var res = intlist.Intersect(intlist2).ToList();
            // res.ForEach(i => Console.WriteLine(i));

            //d
            //var res = intlist.Where(i => (Math.Sqrt(i) - Math.Floor(Math.Sqrt(i))) == 0).ToList();
            //res.ForEach(i => Console.WriteLine(i));


            //e
            //var res = intlist.GroupBy(i => i % 2 == 0).OrderBy(grp => grp.Key).Select(grp => new { key = grp.Key, item = grp.Select(e => e) }).ToList();
            //res.ForEach(i => { Console.WriteLine("key : {0}", Convert.ToInt32(i.key));i.item.ToList().Print(); });



            #endregion
            ////////////////////////// 2
            #region part2
            List<Employee> emps = new List<Employee>
            {
               new Employee {Id = 1, Name = "Emp 1", Age = 21, Gender = Gender.Male, DeptId = 1},
               new Employee {Id = 2, Name = "Emp 2", Age = 22, Gender = Gender.Male, DeptId = 1},
               new Employee {Id = 3, Name = "Emp 3", Age = 23, Gender = Gender.Male, DeptId = 2},
               new Employee {Id = 4, Name = "Emp 4", Age = 24, Gender = Gender.Male, DeptId = 1},
               new Employee {Id = 5, Name = "Emp 5", Age = 25, Gender = Gender.Female, DeptId = 2}

            };

            List<Employee> emps2 = new List<Employee>
            {
               new Employee {Id = 1, Name = "Emp 1", Age = 21, Gender = Gender.Male, DeptId = 1},
               new Employee {Id = 3, Name = "Emp 2", Age = 25, Gender = Gender.Male, DeptId = 2},
               new Employee {Id = 3, Name = "Emp 3", Age = 23, Gender = Gender.Male, DeptId = 1}

            };

            var depts = new List<Department>
                {
                new Department{Id = 1, Name="EB"},
                new Department{Id = 2, Name = "SD"}
                };

            EmployeeComparer ec = new EmployeeComparer();

            //a
            //var res = emps.Join(depts,
            //    e => e.DeptId,
            //    d => d.Id,
            //    (e, d) => new { empName = e.Name,Age=e.Age,Gender=e.Gender,depName = d.Name }).Where(r => r.depName == "EB").ToList();
            //  res.ForEach(i => Console.WriteLine("Employee Name : {0} , Age : {1} ,Gender : {2}",i.empName,i.Age,i.Gender));


            //b
            //var res = emps.Intersect(emps2, ec).ToList();
            //res.ForEach(i => Console.WriteLine("Employee Name : {0} , Age : {1} ,Gender : {2}", i.Name, i.Age, i.Gender));

            //c
            //var res = emps.Skip(3).ToList();
            //res.ForEach(i => Console.WriteLine("Employee Name : {0} , Age : {1} ,Gender : {2}", i.Name, i.Age, i.Gender));

            //d

            //var res = emps.Join(depts,
            //    e => e.DeptId,
            //    d => d.Id,
            //    (e, d) => new { Name = e.Name, Age = e.Age, Gender = e.Gender, depName = d.Name }).GroupBy(e => e.depName)
            //    .Select(grp => new { key = grp.Key, empsName = grp.Select(e => e.Name) }).ToList();
            //res.ForEach(i => Console.WriteLine("Department Name : {0} ,Employee Name : {1}",i.key,i.empsName.ToList()));

            #endregion
            //////////////////// 3
            #region part3
            var products = new List<Product>
            {
                new Product {Id=1, Name="coffe", Category = Category.Beverages, Price= 20 },
                new Product {Id=1, Name="pepper", Category = Category.Condiments, Price=10},
                new Product {Id=1, Name="pepsi", Category = Category.Beverages, Price= 5 },
                new Product {Id=1, Name="meat", Category = Category.Meat, Price= 200 },
                new Product {Id=1, Name="fish", Category = Category.Seafood, Price= 300 },
            };

            //a
            //var res = products.GroupBy(p => p.Category).Select(grp => new { Category = grp.Key, count = grp.Count() }).ToList();
            //res.ForEach(i => Console.WriteLine("Category : {0} ,NumberOF Product: {1}", i.Category,i.count));

            //b
            //var res = products.GroupBy(p => p.Category).Select(grp => new { Category = grp.Key, min = grp.Min(p=>p.Price) }).ToList();
            //res.ForEach(i => Console.WriteLine("Category : {0} ,Min Price: {1}", i.Category, i.min));

            //c

            //var res = products.GroupBy(p => p.Category).Select(grp => new { Category = grp.Key, products = grp.OrderBy(p=>p.Price) }).ToList();
            //res.ForEach(i => { Console.WriteLine("Category : {0}", i.Category); i.products.ToList().Print(); });

            #endregion

            Console.ReadLine();
        }


    }
}
