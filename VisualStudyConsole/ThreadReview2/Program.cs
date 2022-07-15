using System;
using System.Threading;

namespace ThreadReview2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Ide);
            Thread t2 = new Thread(Sql);
            Thread t3 = new Thread(Win)
            {

            };
            t1.Start();
            t2.Start();
            t3.Start();

            
            
        }
        private static void Ide()
        {
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : Ide tarting");
            Thread.Sleep(3000);
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : Ide End");
        }

        private static void Sql()
        {
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : Sql Starting");
            Thread.Sleep(3000);
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : Sql End");
        }

        private static void Win()
        {
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : Win Starting");
            Thread.Sleep(3000);
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : Win End");
        }

        private static void C()
        {
            global::System.Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : C Starting");
            Thread.Sleep(200);
            global::System.Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : C End");
        }
    }
}
