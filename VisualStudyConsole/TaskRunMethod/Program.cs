using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TaskRunMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var service = new WeatherService();
            //var forcast = await service.GetForcastAsync(DateTime.Now);

            //foreach(var w in forcast)
            //{
            //    Console.WriteLine($"{w.Date}\t{w.TemperatureC}\t{w.TemperatureF}\t{w.Summary}");
            //}
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Main 실행");
            stopwatch.Start();
         
                Cooking cooking = new Cooking();
                
                cooking.MakeRiceAsync();
                cooking.MakeSoupAsync();
                cooking.MakeEggeAsync();
           
         
            stopwatch.Stop();
            Console.WriteLine("Main 종료");
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.ReadKey();

            
        }
        static async Task CookingAsync()
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Main 실행");
            stopwatch.Start();
            Cooking cooking = new Cooking();
            await cooking.MakeRiceAsync();
            Console.WriteLine("Rice End");
            await cooking.MakeSoupAsync();
            Console.WriteLine("Soup End");
            await cooking.MakeEggeAsync();
            Console.WriteLine("Egg End");
            stopwatch.Stop();
            Console.WriteLine("Main 종료");
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

    }

    public class Cooking
    {
        public Rice MakeRice()
        {
            Console.WriteLine("Cooking for Rice");
            Thread.Sleep(2000);
            return new Rice();
        }

        public Task<Rice> MakeRiceAsync()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Cooking for Rice");
                Thread.Sleep(2000);
                Console.WriteLine("Rice End");
                return new Rice();
            });
        }

        public Soup MakeSoup()
        {
            Console.WriteLine("Cooking for Soup");
            Thread.Sleep(2000);
            Console.WriteLine("Soup End");
            return new Soup();
        }

        public Task<Soup> MakeSoupAsync()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Cooking for Soup");
                Thread.Sleep(2000);
                Console.WriteLine("Soup End");
                return new Soup();
            });
        }

        public Egg MakeEgg()
        {
            Console.WriteLine("Cooking for Egg");
            Thread.Sleep(2000);
            Console.WriteLine("Egg End");
            return new Egg();
        }

        public Task<Egg> MakeEggeAsync()
        { 
             Console.WriteLine("Cooking for Egg");
            long sum = 0;
            for (int i = 0; i < 1_000_000_000; i++)
            {
                sum += i;
            }
            Console.WriteLine("Egg End");
            return Task.FromResult(new Egg());
        }
    }
}
