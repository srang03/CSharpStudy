using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => DoPrint());

            Console.WriteLine("await");
            Thread.Sleep(3);
        }
        static async void DoPrint()
        {
            await PrintNumberAsync();
        }

         static async Task PrintNumberAsync()
        {
            await Task.Run(() =>
            {
                for(int i = 0; i < 300; i++)
                {
                    Console.WriteLine(i + 1);
                }
            });

        }
    }
}
