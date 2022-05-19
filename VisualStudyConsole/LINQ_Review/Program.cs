using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ는 Language INtegrated Query의 약자로 C#에서 컬렉션 형태의 데이터를 가공할때 유용하게 쓸 수 있는 확장 메서드를 제공한다.
namespace LINQ_Review
{
    class Program
    {
        public static List<int> list = new List<int>() { 1, 5, 4, 2, 3, 7, 6 };
        public static List<int> list2 = new List<int>() { 10, 10, 10 };

        static void Main(string[] args)
        {
            Console.WriteLine($"{SytaxLINQ.LINQ_SUM(list)}"); 
            Console.WriteLine($"{SytaxLINQ.LINQ_COUNT(list)}");
            Console.WriteLine($"{SytaxLINQ.isEven(3)}");
            ShowAll(SytaxLINQ.GetEvenNumbers(list));
            Console.WriteLine($"홀수 개수 : {SytaxLINQ.GetCountOfOddNumbers(list)}");
            Console.WriteLine($"10을 가졌니 : {SytaxLINQ.HasValue(list, 10)}");
            Console.WriteLine($"10을 모두 가졌니 : {SytaxLINQ.AllHasValue(list2, 10)}");

            // ShowAll(SytaxLINQ.SortedASC(list));
            //ShowAll(SytaxLINQ.SortedEvenNumbers(list));

            //Console.WriteLine($"{SytaxLINQ.GetOnlyOne(list)}");
            //Console.WriteLine($"{SytaxLINQ.GetOnlyOneOrDefault(list)}");
            //Console.WriteLine($"{SytaxLINQ.GetFirstValue(list)}");
            // ShowAll(SytaxLINQ.QuerySelect(list));
            SytaxLINQ.ExtensionLINQ(list);
        }
        static void ShowAll(List<int> list)
        {
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
        
    }

    class SytaxLINQ
    {
        // [1] LINQ 기본 확장 메서드
        // 컬렉션 데이터에서 자주 사용되는 메서드를 확장시켜서 제공한다.
        public static int LINQ_SUM(List<int> list)
        {
            return list.Sum();
        }

        public static int LINQ_COUNT(List<int> list)
        {
            return list.Count();
        }

        public static double LINQ_AVG(List<int> list)
        {
            return (double)list.Average();
        }

        public static int LINQ_MIN(List<int> list)
        {
            return list.Min();
        }

        public static int LINQ_MAX(List<int> list)
        {
            return list.Max();
        }

        // [2] 람다식 조건처리
        // LINQ에서 제공하는 확장 메서드들은 매개변수로 람다식을 받는다.
        // 람다식은 () => 형태로 goes to 라고 불린다.

        // 람다식은 식 람다(Expression Lambda)와 문 람다(Statement Lambda)가 있다.
        // 식 람다 (입력 매개변수) => 식 
        // ex) x => x + 1
        // 문 람다 (입력 매개변수 ) => { 문; }
        // ex) x => { return x + 1; }

        public static bool isEven (int x) => x % 2 == 0;

        public static List<int> GetBiggerThanThree(List<int> list)
        {
            IEnumerable<int> result = list.Where(x => x > 3);
            return result.ToList();
        }
         public static List<int> GetEvenNumbers(List<int> list)
        {
            IEnumerable<int> result = list.Where(x => x % 2 == 0);
            return result.ToList();
        }

        public static int GetCountOfOddNumbers(List<int> list)
        {
            return list.Count(x => x % 2 != 0);
        }

        public static bool HasValue(List<int> list, int num)
        { 
            return list.Any(x => x == num);
        }

        public static bool AllHasValue(List<int> list, int num)
        {
            return list.All(x => x == num);
        }

        // [3] 람다식 정렬
        public static List<int> SortedASC(List<int> list)
        {
            return list.OrderBy(x => x).ToList();
        }
        public static List<int> SortedDesc(List<int> list)
        {
            return list.OrderByDescending(x => x).ToList();
        }

        // [4] 확장 메서드 체이닝
        public static List<int> SortedEvenNumbers(List<int> list)
        {
            return list.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
        }

        // [5] 특정 문자열을 포함하는 컬렉션 가져오기
        public static List<string> ContainsValue(List<string> list, string value)
        {
            return list.Where(str => str.Contains(value)).ToList();
        }
        
        // [6] Single(), SingOrDefault()
        // 조건에 맞는 데이터를 하나만 가져온다.
        // Single() : 조건에 맞는 데이터가 없으면 오류 발생하기 때문에 예외처리 필수
        // SingleOrDefault : 조건에 맞는 데이터가 없으면 null 값 또는 기본값 반환

        public static int GetOnlyOne(List<int> list)
        {
            return list.Single(x => x == 2);
        }
        public static int GetOnlyOneOrDefault(List<int> list)
        {
            return list.SingleOrDefault(x => x == 10);
        }
        
        // [7] First(), FirstOrDefault()
        public static int GetFirstValue(List<int> list)
        {
            return list.First(x=> x== 2);
        }

        // [8] 쿼리 구문
        public static List<int> QuerySelect(List<int> list)
        {
            IEnumerable<int> result = from n in list where n % 2 == 0 select n;
            return result.ToList();
        }

        public static void ExtensionLINQ(List<int> list)
        {
            list.Where(n => n > 2).ToList().ForEach(e =>Console.WriteLine(e));
        }
    }
}

 

