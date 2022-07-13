using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsnycReview4
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : main start ----------");

         
                await t1();
                await t2();
          
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : main end ----------");
            Console.ReadKey();
        }

    
        static async Task t1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : t4 start");
                Thread.Sleep(2000);
                Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : t4 end");
            }); 
        }

        static async Task t2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : t5 start");
                Thread.Sleep(2000);
                Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : t5 end");
            }); 
        }
    }
}
