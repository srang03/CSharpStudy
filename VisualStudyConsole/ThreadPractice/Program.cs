using System;
using System.Diagnostics;
using System.Threading;

namespace ThreadPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("시스템 시작");
            ThreadStart ts1 = new ThreadStart(ThreadPractice.Ide);
            Thread t1 = new Thread(new ThreadStart(ts1));
            Thread t2 = new Thread(ThreadPractice.Sql);
            Thread t3 = new Thread(new ThreadStart(ThreadPractice.Win))
            {
                Priority = ThreadPriority.Highest
            };
            

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join(); t2.Join(); t3.Join();

            Process.Start("Notepad.exe");
            
            Console.WriteLine("시스템 종료");
        }
    }

    public class ThreadPractice
    {
        public static void Ide()
        {
            Thread.Sleep(3000);
            Console.WriteLine("[3] IDE : Visual Studio 2022");
        }

        public static void Sql()
        {
            Thread.Sleep(3000);
            Console.WriteLine("[2] SQL : SQL Server");
        }

        public static void Win()
        {
            Thread.Sleep(3000);
            Console.WriteLine("[1] OS : Window 10 Pro");
        }
         
    }
}
