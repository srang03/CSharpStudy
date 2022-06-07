using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace asyncDemoReivew
{
    public class AsyncDemo
    {
       static async Task PrintNumberAsync()
        {
            await Task.Run(() => {
                for (int i = 0; i < 300; i++)
                {
                    Console.WriteLine(i + 1);
                }
            });
        }

        public static async void DoRun()
        {
            await PrintNumberAsync();
        }
    }
    public class AsyncAwaitSimple
    {
        public static async Task DoAsync() 
        {
            using (var client = new HttpClient()) {
                var r = await client.GetAsync("https://www.naver.com");
                var c = await r.Content.ReadAsStringAsync();
                Console.WriteLine(c);
                Console.WriteLine("end"); 
            }
        }

        public static async void Test()
        {
            await Task.Run(() => DoAsync());
        }
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            
            await AsyncAwaitSimple.DoAsync();
            Console.WriteLine("async awiat");
            Thread.Sleep(5);
            //Task.Run(() => AsyncAwaitSimple.DoAsync());
        }
    }
}
