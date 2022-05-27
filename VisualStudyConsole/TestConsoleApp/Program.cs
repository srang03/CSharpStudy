using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 3, 4, 5, 2, 1, 8, 7, 6 };
            MyAPI.Program.SelectOrder(list);

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
