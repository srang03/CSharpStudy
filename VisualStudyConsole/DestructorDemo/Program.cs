using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Run();

            Car car2 = new Car("호이");
            car2.Run();
        }
    }

    public class Car
    {
        string _name;
        public Car():this("기본") { }

        public Car(string name)
        {
            this._name = name;
            Console.WriteLine($"[1] {_name} Created");
        }
        public void Run() => Console.WriteLine($"[2] {_name} Running...");

        ~Car() => Console.WriteLine($"[3] {_name} end");
    }
}
