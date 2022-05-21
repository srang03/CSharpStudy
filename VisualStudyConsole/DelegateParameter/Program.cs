using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateParameter
{
    class Program
    {
        delegate int Del(int x, int y);
        static void Main(string[] args)
        {
            Print((int x, int y) => x + y, 1, 2);
            Print((int x, int y) => x * y, 1, 2);
        }

        static void Print(Del func, int x, int y) => Console.WriteLine(func(x, y)); 
        
    }
}
