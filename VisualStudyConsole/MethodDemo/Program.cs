using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "";
            

            Car car1 = new Car();
            car1.Map(ref title);

            Console.WriteLine($"[3]{title}");

            Car car2 = new Car();
            
            car2.Map("ASP.NET", ".NET Core", "C#");
            car2.PrintMessage("message");
            car2.PrintMessage("message2", "pre");
            car2.PrintMessage("message3", "pre", "post");


        }
    }
}
