using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RealityforThread
{
    internal class Program2
    {
        static async Task Main()
        {
            // Part 1
            Console.WriteLine("Task 1");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            var client = new HttpClient();

            // Part 2
            var task1 = await client.GetStringAsync("https://google.com");
            int a = 0;
            
            for(int i = 0; i<1_000_000_000; i++)
            {
                a = i + 1;
            }

            // Part 3
            var task2 = await client.GetStringAsync("https://google.com");
            Console.WriteLine("Task 2");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            for(int i = 0; i<1_000_000_000; i++)
            {
                a = i + 1;
            }
            
            var task3 = await client.GetStringAsync("https://www.naver.com");
            Console.WriteLine("Task 3");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
