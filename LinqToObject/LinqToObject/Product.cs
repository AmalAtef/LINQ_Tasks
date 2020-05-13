using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int Price { get; set; }
    }

    enum Category
    {
        Beverages,
        Condiments,        
        Meat,
        Seafood
    }
}
