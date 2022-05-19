using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> todos = new Dictionary<int, string>();

            todos.Add(1, "C#");
            todos.Add(2, "ASP.NET");
            todos.Add(3, "Forms");

            

            foreach (var item in todos)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }
}
