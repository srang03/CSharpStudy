using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncReview2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : main staring");
            await Task.Run(Run);
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : main end");
        }

        static async Task TaskRun()
        {       
            await Run();
        }

        static async Task Run()
        {
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : taskRun staring");
            await Task.Run(() =>
            {
                for (int i = 0; i < 1_000; i++)
                {
                    Console.WriteLine(i);
                }
            });
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : taskRun end");
        }
    }
}
