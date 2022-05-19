using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korea
{
    namespace Seoul
    {
        public class City
        {
            public string Name = "Korea.Seoul.City";

            public void name() => Console.WriteLine($"The Biggest City : {Name}");
        }
    }
    namespace Busan
    {
        public class City
        {
            public string Name = "Korea.Busan.City";
            public void name() => Console.WriteLine($"2nd City : {Name}");
        } 
    }
   
}
