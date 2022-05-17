using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            // 널 병합 연산자 (Null Coalescing Operator) : ??
            string message;
            message = null;

            string result = message ?? "값을 입력해주세요";

            Console.WriteLine(result);


        }
    }
}
