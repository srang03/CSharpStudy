using System;

namespace InterfaceExam
{
    interface ICar
    {
        void Go();
    }

    class Car : ICar
    {
        public void Go() => Console.WriteLine("Go Go");
        // 상속한 인터페이스에 정의된 모든 맴버를 반드시 구현해야 한다.
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
