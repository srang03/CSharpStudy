using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static IEnumerable<int> Good(int[] numbers, int greater)
        {
            List<int> list = new List<int>();

            foreach (var item in list)
            {
                if(item > greater)
                {
                    list.Add(item);
                }
            }

            return list;
        }

        static IEnumerable<int> Good2(int[] numbers, int greater)
        {
            foreach (var item in numbers)
            {
                if(item > greater)
                {
                    yield return item;
                }
            }
        }
    }
}
