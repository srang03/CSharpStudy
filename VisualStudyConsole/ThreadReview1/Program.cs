using System;
using System.Threading;

namespace ThreadReview1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"[T] : {Thread.CurrentThread.ManagedThreadId} Start");
            Thread t1 = new Thread(print);
            t1.Start();
            Console.WriteLine($"[T] : {Thread.CurrentThread.ManagedThreadId} End");
        }

        static void print()
        {
            Console.WriteLine($"[T] : {Thread.CurrentThread.ManagedThreadId} Start");
            Thread.Sleep(2000);
            Console.WriteLine($"[T] : {Thread.CurrentThread.ManagedThreadId} End");
            return;
        }
    }
}
