using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameter
{
    class Pair <T, V>
    {
        public T First { get; set; }
        public V Second { get; set; }

        public Pair(T first, V second)
        {
            First = first;
            Second = second;
        }
     }
    internal class Program
    {
        static void Main(string[] args)
        {
            var my = new Pair<string, bool>("A", true);
            Console.WriteLine($"{my.First} : {my.Second}");

            var tuple = new Pair<int, double>(1, 3.14);
            Console.WriteLine($"{tuple.First} : {tuple.Second}");
        }
    }
}
