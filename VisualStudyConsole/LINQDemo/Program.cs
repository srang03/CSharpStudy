using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            //SumExample(numbers);
            //SumLINQ(numbers);
            //MaxLINQ(numbers);
            //MinLINQ(numbers);
            //FindEven(numbers);
            //FindOdd(numbers);
            DoubleValue(numbers);
            OrderBy();
            PrntEvenSum();
            query();
        }
        // [0] 컬렉션 출력 메서드
        public static void ShowAll(List<int> list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        public static void ShowAll(int[] list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        public static void ShowAll(List<string> list)
        {
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
        }

        // [1] LINQ 사용 (System.Linq)
        public static void SumExample(int[] numbers)
        {
                int sum = 0;

                foreach (int i in numbers)
                {
                    sum += i;
                }

                Console.WriteLine($"sum : {sum}");
        }

        public static void MaxLINQ(int[] numbers)
        {
            Console.WriteLine($"max : {numbers.Max()}");
        }
        public static void MinLINQ(int[] numbers)
        {
            Console.WriteLine($"min : {numbers.Min()}");
        }
        public static void SumLINQ(int[] numbers)
        {
            Console.WriteLine($"sum : {numbers.Sum()}");
        }
        public static void AvgLINQ(int[] numbers)
        {
            Console.WriteLine($"avg : {numbers.Average()}");
        }

        // [2] WHERE 확장 메서드
        public static void FindEven(int[] numbers)
        {
            List<int> list = numbers.Where(n => n % 2 == 0).ToList(); // numbers 에서 짝수를 읽어온다.
            ShowAll(list);
        }

        public static void FindOdd(int[] numbers)
        {
            List<int> list = numbers.Where((x) => x % 2 != 0).ToList(); // numbers 에서 짝수를 읽어온다.
            ShowAll(list);
        }

        // [3] 메서드 체인
        // Where 메서드와 Max 메서드를 함께 사용하는 것처럼 여러 확장 메서드를 체이닝하여 사용할 수 있다.
        public static void MethdChain(int[] numbers)
        {
            Console.WriteLine(numbers.Where(x=>x % 2 != 0).Max());
        }

        // [4] Select 확장 메서드
        public static void DoubleValue(int[] numbers)
        {
            List<int> list = numbers.Select(x => x*2).ToList();
            ShowAll(list);
        }

        // [5] 정렬
        public static void OrderBy()
        {
            List<string> techs = new List<string>();
            techs.Add("C#");
            techs.Add("ASP.NET");
            techs.Add("Blazor");

            List<string> result = techs.OrderBy(x => x).ToList(); // 오름차순
            ShowAll(result);

            result = techs.OrderByDescending(x => x).ToList(); // 내림차순
            ShowAll(result);
        }

        // [6]
        public static void PrntEvenSum()
        {
            var numbers = Enumerable.Range(1, 100);

            Console.WriteLine(numbers.Where(x => x % 2 == 0).ToList().Sum());
            
            ShowAll(numbers.OrderByDescending(n => n).Where(x => x % 2 == 0).Take(3).ToList());
            ShowAll(numbers.OrderByDescending(n => n).Where(x => x % 2 == 0).Skip(3).Take(3).ToList());
        }


        // [7] Query Syntax
        public static void query()
        {
            var numbers = Enumerable.Range(1, 100);
            var q = from n in numbers where n % 2 == 0 select n; // Query Syntax 쿼리 구문 사용
            ShowAll(q.ToList());

            // var qq = numbers.Where(x => x % 2 == 0); // Method Syntax
            // ShowAll(qq.ToList());
        }

        // Database 연동하는 과정 속에 LINQ 사용은 필수이다.


    }
}
