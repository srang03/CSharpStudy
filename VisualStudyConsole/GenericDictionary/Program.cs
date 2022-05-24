using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> KeyValuePairs = new Dictionary<int, double>();

            for(int i = 1; i <= 10; i++)
            {
                KeyValuePairs.Add(i, i*i * (0.1*i));
            }

            for(int i = 1; i < KeyValuePairs.Count; i++)
            {
                Console.WriteLine($"{KeyValuePairs[i]} - {KeyValuePairs[i]}");
            }
        }
    }

   
}
