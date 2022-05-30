using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDemoEx
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await TaskAsync();


        }
        // 1. 비동기식 메서드 호출 DoAsync()
        static async Task TaskAsync()
        {
            
            await Task1();
            await Task2();

            Console.WriteLine("작업 완료");
        }

        static async Task Task1()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("[Tesk 01] : " + i);
            }
        }

        static async Task Task2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("[Tesk 02] : " + i);
            }
        }
    }
}
