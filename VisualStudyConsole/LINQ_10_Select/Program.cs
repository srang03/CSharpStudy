using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ (Language INtegrated Query)
namespace LINQ_10_Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            
            var evenNumbers = from num in arr where num % 2 == 0 select num;

            // LINQ는 SQL Syntax와 비슷한 구문을 C#에서 사용할 수 있도록 기능을 제공한다.
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }


            var evenNumbers_where = arr.Where(num  => num % 2 == 0);
            foreach (var item in evenNumbers_where)
            {
                Console.WriteLine(item);
            }
        }
    }
}
