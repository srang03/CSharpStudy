using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 메서드 구문(Method Syntax) 과 쿼리 구문(Query Syntax)
namespace LINQ_11_QuerySyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 1, 4, 5 };

            // [1] 메서드 구문
            IEnumerable<int> methodSyntax = numbers.Where(x => x % 2 == 0).OrderBy(x => x);


            // [2] 쿼리 구문
            // SQL 쿼리 구문과 비슷한 형태로 
            var querySyntax = from num in numbers where num % 2 == 0 orderby num select num  ;
            
        }
    }
}
