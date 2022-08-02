using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharrpReivew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.LongRunning(Callback);
        }
        static void Callback(int i)
        {
            Console.WriteLine(i);
        }
    }

    class MyClass
    {
        public delegate void Callback(int i)
            ;
        public void LongRunning(Callback obj)
        {
            for (int i = 0; i < 10_000; i++)
            {
                // Do something
                obj(i);
            }
        }
    }

}
