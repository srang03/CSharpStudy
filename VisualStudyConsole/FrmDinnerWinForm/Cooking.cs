using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrmDinnerWinForm
{
    internal class Cooking
    {
        public static Rice MakeRice()
        {
            Console.WriteLine("밥 준비 시작");
            Thread.Sleep(2000);
            Console.WriteLine("밥 생성 완료");
            return new Rice();
        }

        public static Soup MakeSoup()
        {
            Console.WriteLine("스프 준비 시작");
            Thread.Sleep(2000);
            Console.WriteLine("스프 생성 완료");
            return new Soup();
        }

        public static Egg MakeEgg()
        {
            Console.WriteLine("Egg 준비 시작");
            Thread.Sleep(5000);
            Console.WriteLine("Egg 생성 완료");
            return new Egg();
        }

        public async static Task<Rice> MakeRiceAsync()
        {
            Console.WriteLine("밥 준비 시작");
            await Task.Delay(4000);
            Console.WriteLine("밥 생성 완료");
            return new Rice();
        }

        public async static Task<Soup> MakeSoupAsync()
        {
            Console.WriteLine("스프 준비 시작");
            await Task.Delay(8000);
            Console.WriteLine("스프 생성 완료");
            return new Soup();
        }

        public async static Task<Egg> MakeEggAsync()
        {
            Console.WriteLine("Egg 준비 시작");
            await Task.Run(()=>Thread.Sleep(10000));
            Console.WriteLine("Egg 생성 완료");
            return new Egg();
        }

        public async static void DoRice()
        {
            await MakeRiceAsync();
        }

        public async static void DoSoup()
        {
            await MakeSoupAsync();
        }

        public async static void DoEgg()
        {
            await MakeEggAsync();
        }


    }

    public class Rice
    {
        
    }

    public class Soup
    {

    }

    public class Egg
    {

    }
}
