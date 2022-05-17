using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    // C# 프로그램이 언어는 암기과목이다.

    // .NET의 Built-In 내장 함수
    // 구조체 > 열거형 > 클래스

    // 데이터를 잠깐 보관하여 묶어서 관리할 때 사용
    // Static 메서드가 없는 클래스를 인스턴스라고 한다. (Instance == Object)

    // .NET > C#
    // Built-In class
    // -- Console, Environment, Math, Random ...
    // User-Defined Class
    // -- MyClass, Car, Product, Person ...

    internal class Program
    {
        static void Main(string[] args)
        {

            Square square = new Square(); // 생성자 => 객체 초기화 수행
            square.width = 100;
            square.height = 200;
            Console.WriteLine(square.width);
            

            Console.WriteLine(Environment.NewLine); 
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.MachineName);
        }
    }

    class Square {
        public int width;
        public int height;
    }



}
