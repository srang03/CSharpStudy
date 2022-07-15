using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskRunMethod
{
    public class Cooking
    {
        public Rice MakeRice()
        {
            Console.WriteLine("Cooking for Rice");
            Thread.Sleep(2000);
            Console.WriteLine("Rice End");
            return new Rice();
        }

        public Task<Rice> MakeRiceAsync()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Cooking for Rice");
                Thread.Sleep(3000);
                Console.WriteLine("Rice End");
                return new Rice();
            });
        }

        public Soup MakeSoup()
        {
            Console.WriteLine("Cooking for Soup");
            Thread.Sleep(1000);
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
