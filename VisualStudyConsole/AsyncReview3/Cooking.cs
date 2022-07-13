using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncReview3
{

    public class Rice
    {

    }

    public class Soup
    {

    }

    public class Food
    {

    }

    public class Cooking
    {
        public Rice MakeRice()
        {
            Console.WriteLine($"[T{Thread.CurrentThread.ManagedThreadId}] : Creating Rice...");
            Thread.Sleep(3000);
            Console.WriteLine($"[T{Thread.CurrentThread.ManagedThreadId}] : End Rice");
            return new Rice();
        }

        public Soup MakeSoup()
        {
            Console.WriteLine($"[T{Thread.CurrentThread.ManagedThreadId}] : Creating Soup...");
            Thread.Sleep(3000);
            Console.WriteLine($"[T{Thread.CurrentThread.ManagedThreadId}] : End Soup");
            return new Soup();
        }   
        
        public Food MakeFood()
        {
            Console.WriteLine($"[T{Thread.CurrentThread.ManagedThreadId}] : Creating Food...");
            Thread.Sleep(3000);
            Console.WriteLine($"[T{Thread.CurrentThread.ManagedThreadId}] : End Food");
            return new Food();
        }

        public async Task<Rice> MakeRiceAsync()
        {
           
            await Task.Run(() => {
                Console.WriteLine($"[T{Thread.CurrentThread.ManagedThreadId}] : Creating Rice...");
                Thread.Sleep(3000); 
                           Console.WriteLine($"[T{Thread.CurrentThread.ManagedThreadId}] : End Rice");
            });
 
            return await Task.FromResult<Rice>(new Rice());
        }

        public async Task<Soup> MakeSoupAsync()
        {
           
            await Task.Run(() => {
                Console.WriteLine($"[T{Thread.CurrentThread.ManagedThreadId}] : Creating Soup...");
                Thread.Sleep(3000);
                Console.WriteLine($"[T{Thread.CurrentThread.ManagedThreadId}] : End Soup");
            });
         
            return await Task.FromResult<Soup>(new Soup());
        }
        public async Task<Food> MakeFoodAsync()
        {
          
            await Task.Run(() => {
                Console.WriteLine($"[T{Thread.CurrentThread.ManagedThreadId}] : Creating Food...");
                Thread.Sleep(3000);
                Console.WriteLine($"[T{Thread.CurrentThread.ManagedThreadId}] : End Food");
            });
            
            return await Task.FromResult<Food>(new Food());
        }
    }
}
