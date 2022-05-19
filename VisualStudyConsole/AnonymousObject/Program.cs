using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hong = new
            {
                Name = "이안",
                age = 27,
                status = true
            };

            if (hong.status)
            {
                Console.WriteLine($"{hong.Name}님 반갑습니다.");
            }
        }
    }
}
