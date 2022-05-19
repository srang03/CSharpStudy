using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 정적 맴버 호출시 클래스의 정적 생성자 실행
            Person.Show();

            // 생성자 호출시 클래스의 인스턴스 생성자 실행
            Person person1 = new Person();
            Person person2 = new Person(33);
            person1.Print();
            person2.Print();
        }
    }

    public class Person
    {
        private static readonly string _Name;
        private int _Age;

        static Person() { _Name = "이름 없음"; }
        public Person() { _Age = 21; }

        public Person(int age)
        {
            _Age = age;
        }

        public static void Show()
        {
            Console.WriteLine($"이름 : {_Name}");
        }
        public void Print()
        {
            Console.WriteLine($"나이 : {this._Age}");
        }

     }
}
