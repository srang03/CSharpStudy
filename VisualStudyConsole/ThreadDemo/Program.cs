using System;
using System.Threading;
using System.Threading.Tasks;

// 스레드(Thread) : 작업자 한 사람
// 멀티 스레드 : 작업자 여러명

// 스레드를 더 편하게 사용할 수 있는 비동기식 (async, await)가 있다.
namespace ThreadDemo
{
    public class Restaurant
    {
        #region 동기 방식
        public void MakeFood()
        {
            Console.WriteLine($"요리 시작");
            DateTime start = DateTime.Now;

            void Egg()
            {
                Thread.Sleep(3000);
                Console.WriteLine("달걀 요리 3초");
            }
            Egg();

            void Soup()
            {
                Thread.Sleep(5000);
                Console.WriteLine("스프 요리 5초");
            }
            Soup();

            void Rice()
            {
                Thread.Sleep(2000);
                Console.WriteLine("밥 요리 2초");
            }
            Rice();


            Console.WriteLine($"요리 종료");
            double end = (DateTime.Now - start).TotalSeconds;
            Console.WriteLine($"걸린시간 : {(int)end}초");
        }
        #endregion

        #region 비동기 방식
        public void MakeFoodT()
        {
            Console.WriteLine($"요리 시작");
            DateTime start = DateTime.Now;

            void Egg()
            {
                Thread.Sleep(3000);
                Console.WriteLine("달걀 요리 3초");
            }
            Thread t1 = new Thread(new ThreadStart(Egg)); // 1번째 작업자

            void Soup()
            {
                Thread.Sleep(5000);
                Console.WriteLine("스프 요리 5초");
            }
            Thread t2 = new Thread(Soup); // 2번째 작업자

            Thread t3 = new Thread(()=> {
                Thread.Sleep(2000);
                Console.WriteLine("밥 요리 2초");
            }); // 3번째 작업자

            t1.Start(); t2.Start(); t3.Start(); // async 비동기 실행

            t1.Join(); t2.Join(); t3.Join(); // await 작업이 종료될 때까지 대기
            double end = (DateTime.Now - start).TotalSeconds;
            Console.WriteLine($"요리 종료");
           
            Console.WriteLine($"요리시간 : {(int)end}초"); // 10초

            Console.WriteLine("식사 시작");
            //SinglePro();
            MultiPro();
            Console.WriteLine("식사 종료");
            end = (DateTime.Now - start).TotalSeconds;
            Console.WriteLine($"걸린시간 : {(int)end}초");

        }

        private void SinglePro() // 동기 실행
        {
            for (int i = 0; i < 500_000; i++)
            {
                Console.WriteLine("수다");
            }
        }

        private void MultiPro() // 비동기 실행
        {
            Parallel.For(0, 500_000, (i) => Console.WriteLine("수다"));
        }


        #endregion
    }
    internal class Program
    {
        static void Main()
        {
            //new Restaurant().MakeFood();
            new Restaurant().MakeFoodT();
        }
    }
}
