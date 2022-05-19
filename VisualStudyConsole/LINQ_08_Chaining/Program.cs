using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Method Chaining (확장 메서드 체이닝) : 하나 이상의 확장 메서드를 여러번(연쇄적으로) 사용해서 원하는 결과를 받는 것을 의미한다.
namespace LINQ_08_Chaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "C#", "Bootstrap", "Angular" , "ASP.NET", "WinForms" };

            // WHERE 문을 사용해서 조건에 만족하는 요소들을 가진 컬렉션을 OrderBy()를 통해 정렬하여 반환한다.
            var results = list.Where(x => x.Length > 3).OrderBy(x => x).ToList();

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
