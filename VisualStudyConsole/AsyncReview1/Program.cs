using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncReview1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : Main Starting");

            await T1();

            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : Main End");
           
        }

        static async Task T1()
        {
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : Starting");
            await Task.Delay(2000);
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : End");  
        }
    }
}
 