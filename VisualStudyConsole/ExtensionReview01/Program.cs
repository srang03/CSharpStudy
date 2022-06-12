using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionReview01
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string message = "Hello";
            var child = new Child(message);
        }
    }
    public class Parent
    {
        public Parent(string message) => Console.WriteLine(message);
    }

    public class Child : Parent
    {
        public Child(string message) : base(message)
        {

        }
    }
}
