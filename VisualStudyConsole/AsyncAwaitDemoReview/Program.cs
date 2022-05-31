using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemoReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            비동기테스트();
            비동기테스트2();
            Console.WriteLine("아무키나 누르면 프로그램을 종료합니다.");
            Console.ReadLine();
        }
        // [1] 동기 메서드
        private static void SyncMethodTest()
        {
            Console.WriteLine("Operating...");
            Thread.Sleep(3000); // 5초 딜레이: 동기 환경에서만 사용할 것
            Console.WriteLine("End");
        }

        // [2] 비동기 메서드
        public static async Task<int> AsyncMethodTest()
        {
            Console.WriteLine("[1]Operating...");
            await Task.Run(()=> Thread.Sleep(5000));
            Console.WriteLine("[1]End");
            return 1;
        }

        public static async Task<int> AsyncMethodTest2()
        {
            Console.WriteLine("[2]Operating...");
            await Task.Run(() => { for (int i = 0; i < 300; i++)
                {
                    Console.WriteLine(i + 1);
                }
            });
            Console.WriteLine("[2]End");
            return 1;
        }


        private async static void 비동기테스트()
        {
            await AsyncMethodTest();
        }

        private async static void 비동기테스트2()
        {
            await AsyncMethodTest2();
        }
    }
}
