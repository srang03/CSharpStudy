using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Type은 기본적으로 null 값을 가질 수 없음
            int? x = null;

            int y = x ?? default(int); // x값이 null값이면 정수형의 기본값을 입력

            Console.WriteLine(y);
        }
    }
}
