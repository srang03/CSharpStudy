using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUserCreate
{
    public class Cup<T>
    {
        public T Content { get; set; }
    }

    public class Multi<T>
    {
        public T Data { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Cup<int> cup = new Cup<int>();
            cup.Content = 10;
            Console.WriteLine($"{cup.Content}");


            Multi<string> title = new Multi<string>();
            title.Data = "연봉";
            
            Multi<long> income = new Multi<long>();
            income.Data = 100_000_000;

            Console.WriteLine($"{title.Data} {income.Data:#,###}");
        }
    }
}
