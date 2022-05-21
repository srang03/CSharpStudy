using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            hello.Hi(); // FirstDeveloper.cs
            hello.Bye(); // SecondDeveloper.cs

        }
    }
}
