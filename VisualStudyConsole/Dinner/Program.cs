using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Dinner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("[1] 동기 준비 \t [2] 비동기 준비");
            var op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    new Cooking().OnCooking();
                    break;
                case "2":
                    //Cooking ck = new Cooking();
                    //Stopwatch sw = new Stopwatch();
                    //sw.Start();
                    //Rice rice = await ck.MakeRiceAsync();
                    //Soup soup = await ck.MakeSoupAsync();
                    //Egg egg = await ck.MakeEggAsync();

                    //sw.Stop();

                    //Console.WriteLine($"걸린 시간 : {sw.ElapsedMilliseconds}");
                    //Console.WriteLine("식사 준비 완료");
                    //Thread.Sleep(1);
                    break;
                default: throw new Exception(op);
            }
        }
    }
}
