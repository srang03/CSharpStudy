using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrideToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass);
            Console.WriteLine(myClass.ToString());

            string str = new MyClass().ToString();
            Console.WriteLine(str);
        }
    }

    public class MyClass
    {
        public override string ToString()
        {
            //return base.ToString();
            return "반가워요";
            
        }
    }
}
