using System;
using System.Threading;
using System.Threading.Tasks;

namespace SyncMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("메인함수 시작");
            Task.Run(() => Function_A());
            Task.Run(() => Function_B());
            Console.WriteLine("메인함수 종료");
            Console.ReadKey();
        }

        static void Function_A()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("A 작업 시작");
            long sum = 0;
            for(int i = 0; i < 1_000_000_000; i++)
            {
                sum += i;
            }
            Console.WriteLine("A 작업 완료");
  
        }

        static void Function_B()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("B 작업 시작");
            long sum = 0;
            for (int i = 0; i < 1_000_000_000; i++)
            {
                sum += i;
            }
            Console.WriteLine("B 작업 완료");
        }
    }
}
