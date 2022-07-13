using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncReview3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : Main Start -----------");
   
            await CookingAsync();

            Console.WriteLine($"T{Thread.CurrentThread.ManagedThreadId} : Main End ------------");
        
        }
       

        static void CookingSync()
        {
            Cooking cooking = new Cooking();
            cooking.MakeRice();
            cooking.MakeSoup();
            cooking.MakeFood();
        }
        static async Task CookingAsync()
        {
            Cooking cooking = new Cooking();
            await cooking.MakeRiceAsync();
            await cooking.MakeSoupAsync();
            await cooking.MakeFoodAsync();
        }
    }
}
