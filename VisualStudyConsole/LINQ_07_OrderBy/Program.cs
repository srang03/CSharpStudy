using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// OrderBy() : 시퀀스 요소를 키에 따라 오름차순으로 정렬한다.
// OrderByDescending() : 시퀀스 요소를 키에 따라 내림차순으로 정렬한다.
// OrderBy 메서드는 IOrderedEnumerable 타입으로 반환한다.
namespace LINQ_07_OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Bootstrap", "ASP.NET", "C#",  "Angular" };

            // [1] 오름차순 정렬 (알파벳 순서)
            Console.WriteLine("[1] 오름차순 정렬");
            var list_ASC = names.OrderBy(x => x).ToList();

            foreach (var item in list_ASC)
            {
                Console.WriteLine(item);
            }

            // [2] 내림차순 정렬 (알파벳 역순)
            Console.WriteLine("[2] 내림차순 정렬");
            var list_DESC = names.OrderByDescending(x => x).ToList();
            foreach (var item in list_DESC)
            {
                Console.WriteLine(item);
            }
        }
    }
}
