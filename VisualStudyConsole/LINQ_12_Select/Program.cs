using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Select(C#) == Map(다른 언어)
// Select 확장 메서드를 사용하여 새로운 형태의 배열로 가공할 수 있다.
namespace LINQ_12_Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // 각 요소마다 연산을 수행하여 새로운 배열을 생성
            var nums = numbers.Select(x => x * x).ToList();

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
