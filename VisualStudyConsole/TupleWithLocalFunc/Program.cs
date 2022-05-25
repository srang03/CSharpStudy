using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleWithLocalFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0b1, 0B10, 0b0100, 0B000_1000 };
            var (sum, count) = Tally(numbers);
            Console.WriteLine($"{sum}, {count}");
        }

        private static (int sum, int count) Tally(int[] numbers)
        {
           var r = (Sum: 0, Count: 0);
            foreach(int i in numbers)
            {
                Add(i);
            }
            return r;

            void Add(int s)
            {
                r.Sum += s;
                r.Count++;
            }

        }
    
    }
}
