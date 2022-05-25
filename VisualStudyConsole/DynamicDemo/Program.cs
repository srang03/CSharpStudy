using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic x;
            x = 1_234;

            Console.WriteLine($"{x} : {x.GetType()}");

            x = "1_234";
            Console.WriteLine($"{x} : {x.GetType()}");

            dynamic now = DateTime.Now;
            int hour = now.Hour;
            

        }
    }
}
