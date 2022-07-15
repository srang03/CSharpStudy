using System;
using System.Diagnostics;
using System.Threading.Tasks;
using TaskRunMethod;

namespace GiveAsyncTask
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("실행 방식 선택");
            Console.WriteLine("[0]동기  [1]await 비동기  [2]비동기  [3]WhenAll  [4]WhenAny");
            string key = Console.ReadLine();
            Console.WriteLine("메인 함수 시작");
            Cooking cooking = new Cooking();
            switch (key)
            {
                
                case "0":
                    {
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        cooking.MakeRice();
                        cooking.MakeSoup();
                        cooking.MakeEgg();
                        sw.Stop();
                        Console.WriteLine(sw.ElapsedMilliseconds);
                    }
                break;

                case "1":
                    {
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        await cooking.MakeRiceAsync();
                        await cooking.MakeSoupAsync();
                        await cooking.MakeEggeAsync();
                        sw.Stop();
                        Console.WriteLine(sw.ElapsedMilliseconds);
                        break;
                    }
                case "2":
                    {
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        Task<Rice> riceTask = cooking.MakeRiceAsync();
                        Task<Soup> soupTask = cooking.MakeSoupAsync();
                        Task<Egg> eggTask = cooking.MakeEggeAsync();

                        Rice rice = await riceTask;
                        Soup soup = await soupTask;
                        Egg egg = await eggTask;

                        sw.Stop();
                        Console.WriteLine(sw.ElapsedMilliseconds);
                        break;
                    }

                case "3":
                    {
                        Stopwatch sw = new Stopwatch();
                        sw.Start();

                        Task<Rice> riceTask = cooking.MakeRiceAsync();
                        Task<Soup> soupTask = cooking.MakeSoupAsync();
                        Task<Egg> eggTask = cooking.MakeEggeAsync();

                        await Task.WhenAll(riceTask, soupTask, eggTask);
                        sw.Stop();
                        Console.WriteLine(sw.ElapsedMilliseconds);
                        break;
                    }
                default:
                    break;
                    
            }
            Console.WriteLine("메인함수 종료");
            

        }
    }
}
