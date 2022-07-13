using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CookingReview
{
    public class Cooking2
    {
        public int TimeSet { get; set; }

        public Cooking2() : this(3000) { }

        public Cooking2(int timeSet)
        {
            TimeSet = timeSet;
        }
        public async Task<string> CreateRice()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"T{Task.CurrentId} : Starting Rice ...");
                Thread.Sleep(TimeSet);
                Console.WriteLine($"T{Task.CurrentId} : End Rice ...");
            });
            return "rice"; 
        }

        public async Task<string> CreateSoup()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"T{Task.CurrentId} : Starting Soup ...");
                Thread.Sleep(TimeSet);
                Console.WriteLine($"T{Task.CurrentId} : End Soup ...");
            });
            return "Soup";
        }

        public async Task<String> CreateFood()
        {
            await Task.Run(() =>
            {

                Console.WriteLine($"T{Task.CurrentId} : Starting Food ...");
                Thread.Sleep(TimeSet);
                Console.WriteLine($"T{Task.CurrentId} : End Food ...");
            });

            return "Food";
        }
    }

}
