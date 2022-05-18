using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_01_MinAndMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int max = arr.Max(); // 최댓값
            int min = arr.Min(); // 최솟값

            Console.WriteLine($"min : {min}, max : {max}");
        }
    }
}
