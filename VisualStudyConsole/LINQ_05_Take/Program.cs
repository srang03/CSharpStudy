using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Take : 컬렉션(시퀀스)에서 지정한 수만큼 데이터를 가져오기
// 데이터 요소 중에서 내가 원하는 데이터 개수만큼 가져올 수 있다.
namespace LINQ_05_Take
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Range(1, 101); // IEnumerable<int>

            var five = data.Take(5); // 배열 요소 5개 출력
            Console.WriteLine("------------------");
            foreach (var item in five)
            {
                Console.WriteLine(item);
            }

            var even_smaller = data.Where(x => x % 2 == 0).Take(5); // 짝수 하위 5개
            Console.WriteLine("------------------");
            foreach (var item in even_smaller)
            {
                Console.WriteLine(item);
            }

            var even_bigger = data.OrderByDescending(n => n).Where(n => n % 2 == 0).Take(5); // 정렬과 함께 사용 가능 > 짝수 상위 5개 
            Console.WriteLine("------------------");
            foreach (var item in even_bigger)
            {
                Console.WriteLine(item);
            }
        }
    }
}
