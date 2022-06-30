using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RealityforThread
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // part 1
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "_1");
            var client = new HttpClient();

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "_2");

            var task = client.GetStringAsync("https://google.com");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "_3");

            var a = 0;
            for (int i =0; i<10_000_000; i++)
            {
                a += i;
            }

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "_4");
            var page = await task;

            // part2
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "_5"); 
        }
    }
}
