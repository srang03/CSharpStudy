using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_03_ALL
{
    // All() 확장 메서드 : 시퀀스의 모든 요소가 조건을 만족하는지 여부를 결정한다.
    // 특정한 레코드에서 모든 속성이 참일 경우 true를 반환한다.
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] complete = { true, true, true };

            // 배열 또는 컬렉션의 모든 항목이 true일 경우에만 true를 반환한다.
            Console.WriteLine(complete.All(c => c == true));

            complete[0] = false;
            Console.WriteLine(complete.All(c => c == true));
        }
    }
}
