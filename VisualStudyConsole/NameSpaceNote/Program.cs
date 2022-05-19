using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NameSpaceNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo.Car car1 = new Foo.Car();
            car1.Go();

            Bar.Car car2 = new Bar.Car();
            car2.Go();
        }
    }
}
