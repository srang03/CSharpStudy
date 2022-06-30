using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnotherMethodHere();
            Console.ReadLine();
        }

        public static async void AnotherMethodHere()
        {
            // [1]
            await CookEggs();

            // [2]
            CookBacons();
            ToastBread();
        
        }

        public async static Task<bool> CookEggs()
        {
            bool result = false;
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Eggs cooked");
                result = true;
            });

            return result;
        }

        public async static void CookBacons()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
            });
            
            Console.WriteLine("Bacons cooked");
        }

        public static async void ToastBread()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
            });
            Console.WriteLine("ToastBread cooked");
        }
    }
}
