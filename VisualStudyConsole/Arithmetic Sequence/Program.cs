using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 등차 수열 : 연속하는 두 수의 차이가 일정한 수열
// ex) 1부터 100까지 합 : 5050, 1~100까지 차이가 일정한 수열을 등차 수열

namespace Arithmetic_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1] 수열
            // 수열 a(i)
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine(getNumber(i));
            }
        }

        static int getNumber(int num)
        {
            // -1^i - 3*i
            return (int)Math.Pow(-1, num) - (3 * num);
        }
    }
}
