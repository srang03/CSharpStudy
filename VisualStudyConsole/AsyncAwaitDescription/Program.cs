using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDescription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => DoPrint()); // 비동기 작업 영역 (await) 하는 순간에 메인 메서드가 종료된다.
            Console.WriteLine("[1]");
            //Thread.Sleep(1);
        }

        // [1] 동기 메서드
        static void PrintNumber()
        {
            for(int i = 0; i < 300; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
        
        // [2] 비동기 메서드
        // 메서드에 async 키워드
        // void >> Task
        static async Task PrintNumberAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 300; i++)
                {
                    Console.WriteLine(i + 1);
                }
            }
          );
           
            // await를 제공하지 않는 메서드는 Task.Run()에 넣어서 사용해야 한다.
        }

        static async void DoPrint()
        {
            await PrintNumberAsync();
        }
    }
}
