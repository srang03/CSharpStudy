using System;
using System.Threading.Tasks;

namespace DeepDiveinAsync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(await new Tea().MakeTeaAsync());
        }
    }

    class Tea
    {
        //public string MakeTea()
        //{
        //    var water = BoilWater();

        //    Console.WriteLine("take the cups out");

        //    Console.WriteLine("pub tea in cups"); ;

        //    var tea = $"Pour {water} in cups";

        //    return tea;
        //}

        //private string BoilWater()
        //{
        //    Console.WriteLine("Start the kettle");

        //    Console.WriteLine("waiting for the Kettle");
        //    Task.Delay(2000).GetAwaiter().GetResult();

        //    Console.WriteLine("kettle finished boiling");
        //    return "water";

        //}
        public async Task<string> MakeTeaAsync()
        {
            var boilingWater = BoilWaterAsync();

            Console.WriteLine("take the cups out");

            Console.WriteLine("pub tea in cups"); ;

            var a = 0;
            for(int i = 0; i< 100_000_000; i++)
            {
                a += i;
            }

            var water = await boilingWater;

            var tea = $"Pour {water} in cups";

            return tea;
        }
        private async Task<String> BoilWaterAsync()
        {
            Console.WriteLine("Start the kettle");

            Console.WriteLine("waiting for the Kettle");
            await Task.Delay(300);

            Console.WriteLine("kettle finished boiling");
            return "water";
        }
    }
}
