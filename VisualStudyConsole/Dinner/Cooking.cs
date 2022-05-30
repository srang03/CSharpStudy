using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dinner
{
    public class Rice { }
    public class Soup { }
    public class Egg { }

    public class Cooking
    {
        public void OnCooking()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            MakeRice();
            MakeSoup();
            MakeEgg();
            sw.Stop();

            Console.WriteLine($"걸린 시간 : {sw.ElapsedMilliseconds}");
            Console.WriteLine("식사 준비 완료");
        }

        public async Task OnCookingAsync()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            await MakeRiceAsync();
            await MakeSoupAsync();
            await MakeEggAsync();
            sw.Stop();

            Console.WriteLine($"걸린 시간 : {sw.ElapsedMilliseconds}");
            Console.WriteLine("식사 준비 완료");
        }
        private Rice MakeRice()
        {
            Console.WriteLine("밥 생성 중...");
            Thread.Sleep(2_000);
            return new Rice();
        }

        public async Task<Rice> MakeRiceAsync()
        {
            Console.WriteLine("밥 생성 중...");
            await Task.Run(() => Making());
            return new Rice();
        }

        private Soup MakeSoup()
        {
            Console.WriteLine("국 생성 중");
            Thread.Sleep(2_000);
            return new Soup();
        }

        public async Task<Soup> MakeSoupAsync()
        {
            Console.WriteLine("국 생성 중");
            await Task.Delay(2_000);
            return new Soup();
        }
        private Egg MakeEgg()
        {
            Console.WriteLine("계란 생성 중");
            Thread.Sleep(2000);
            return new Egg();
        }

        public async Task<Egg> MakeEggAsync()
        {
            Console.WriteLine("계란 생성 중");
            await Task.Delay(2_000);
            return new Egg();
        }

        private async static Task Making()
        {
            await Task.Delay(2_000);
        } 
    }
}
