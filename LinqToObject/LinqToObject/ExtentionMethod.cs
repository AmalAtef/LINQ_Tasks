using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    public static class ExtentionMethod
    {
        public static void Print<T>(this List<T> items)
        {
            foreach (var item in items)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
        }
    }
}
