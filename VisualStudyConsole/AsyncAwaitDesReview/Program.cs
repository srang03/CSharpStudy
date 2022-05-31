using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitDesReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("operating..");
            DoPrint();
            Console.WriteLine("end");
            Console.WriteLine("press any key");
            Console.ReadLine();
        }
        // [1] 동기식 메서드
        static void PrintNumbers()
        {
            for(int i = 0; i < 300; i++)
            {
                Console.WriteLine(i + 1);
            }
        }

        // [2] 비동기식 메서드
         
        async static Task PrintNumbersAsync()
        {
            await Task.Run(() =>
            {
                PrintNumbers();
            });
        }

        async static void DoPrint()
        {
            await PrintNumbersAsync();
        }
    }
}
