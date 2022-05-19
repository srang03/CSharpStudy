using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Text.

namespace ObjectDemo
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // #2 생성자 호출
            ClassCode classCode = new ClassCode();

            Console.WriteLine(classCode.GetHashCode());     
            
            Car car = new Car(); // Car 객체 생성
            car.Go(); // 인스턴스 맴버이자 인스턴스 메서드

            var car2 = new Car();
            car2.Go();

            Console.WriteLine(car2);
            car2.ToString();

            // 클래스 메서드
            ClassOne.Hi();

            // 인스턴스 메서드
            ClassTwo classTwo = new ClassTwo();
            classTwo.Hello();
        }


        // #1 클래스 파일 생성 (메모리 > 코드 영역)
        public class ClassCode
        {

        }
        
        public class Car
        {
            public void Go() => Console.WriteLine("Run...");
        

            public override string ToString() => "Car Class";
        }

        public class ClassOne
        {
            public static void Hi() => Console.WriteLine("Hi");
        }

        public class ClassTwo
        {
            public void Hello() => Console.WriteLine("Hello");
        }
    }
}
