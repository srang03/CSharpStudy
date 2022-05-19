using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// SingleOrDefault : Single()메서드와 마찬가지로 조건에 맞는 단일값을 가져올 수 있으면서 없다면 에러를 발생시키지 않고 자료형의 기본값을 반환한다.
namespace LINQ_15_SingleOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "C#", "ASP.NET", "TypeScript" };

            // 검색 조건이 맞는 데이터가 있는 경우
            string csharp = names.SingleOrDefault(name => name == "C#"); 
            Console.WriteLine(csharp);


            // 검색 조건이 맞는 데이터가 없는 경우
            string js = names.SingleOrDefault(name => name == "js"); // 찾고자하는 요소가 없을 경우 string이 가지는 기본값인 null값을 반환한다.
            Console.WriteLine(js);
        }
    }
}
