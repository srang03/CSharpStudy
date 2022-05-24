using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassMethod
{
    // 제너릭 클래스와 제너릭 메서드
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello<int> hello = new Hello<int>();

            Console.WriteLine(hello.GetMessage()); 

            Hello<string> msg = new Hello<string>("하이");

            Console.WriteLine(msg.GetMessage());
            msg.Say("곤니찌와");
        }
    }

    public class Hello<T>
    {
        private T _message; // 필드
        public Hello() // 기본 생성자
        {
            _message = default(T);
        }

        public Hello(T message) // 매개 변수가 있는 생성자
        {
            _message = message;
        }

        public void Say(T message) => Console.WriteLine($"Say : {message}"); // 제너릭 메서드
        public T GetMessage() => this._message; // 일반 메서드

    }
}
