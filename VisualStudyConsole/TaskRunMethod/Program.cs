using System;
using System.Diagnostics;
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
}
