using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await SyncDemo.DoAsync();
        }
    }

    public class SyncDemo
    {
        public static void Sum(int x, int y) => Console.WriteLine($"{x} + {y} = {x+y}");
        public static async Task RunAsync()
        {
            string msg = "Async";
            await Task.Delay(1_000);
            Console.WriteLine(msg);
        }
        public static async Task DoAsync()
        {
            using (var Client = new HttpClient())
            {
                var r = await Client.GetAsync("https://www.naver.com");
                var c = await r.Content.ReadAsStringAsync();

                Console.WriteLine(r);

            }
        }
    }
}
