using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("현미");
            Console.WriteLine(cat.Cry());

            Circle circle = new Circle(10);
            Console.WriteLine(circle.GetArea());
        }
    }

    public class Cat
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public string Cry()
        {
            return $"[{this.name}] : 야옹~";
        }

     }


    public class Circle
    {
        private int _radius;
        public Circle() : this(0)
        {

        }
        
        public Circle(int radius)
        {
            this._radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * (double)this._radius * this._radius;
        }
    }
}
