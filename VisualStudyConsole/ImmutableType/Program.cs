using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutableType
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(10);
            // circle.Radius = 10; // 읽기 전용 필드 > 사용 불가능 (불변 형식)
            Console.WriteLine(circle.Radius);

            circle = circle.MakeNew(20);
            Console.WriteLine(circle.Radius);

            //[1] 생성자를 통해서 반지름이 10인 Circle 개체 생성
            Circle circle2 = new Circle(10);
            Console.WriteLine($"Radius: {circle2.Radius} - {circle2.GetHashCode()}");

            //[2] 메서드를 통해서 반지름이 20인 Circle 개체 새롭게 생성
            circle2 = circle2.MakeNew(20);
            Console.WriteLine($"Radius: {circle2.Radius} - {circle2.GetHashCode()}");
        }
    }

    public class Circle
    {
        public int Radius { get; private set; } = 0;
        public Circle(int radius) => Radius = radius;
        public Circle MakeNew(int radius) => new Circle(radius);
    }
}
