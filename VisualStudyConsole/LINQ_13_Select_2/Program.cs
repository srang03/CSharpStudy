using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_13_Select_2
    // Select() 메서드는 새로운 객체에 담아서 새로운 형식의 객체 컬렉션을 반환한다.
    // Select 확장 메서드에서 익명 형식을 사용하기에 var 로 받아야 한다.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> {"C#", "ASP.NET", "JS", "Pyton" };

            // 새로운 익명 클래스 타입으로 파라미터를 넘겨 객체 타입으로 반환
            var nameObject = names.Select(x => new { Name = x + "입니다." });
 
            foreach (var item in nameObject)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
