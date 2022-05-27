using System;
using System.Threading;

namespace ThreadNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] 메인 작업 실행");
            var other = new Thread(new ThreadStart(Ohter));
            other.Start();
            
            Console.WriteLine("[2] 메인 작업 종료");

        }

        static void Ohter()
        {
            Console.WriteLine("스레드 작업 실행");
            Thread.Sleep(3000);
            Console.WriteLine("스레드 작업 종료");
        }
    }
}