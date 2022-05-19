using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ Distinct() : 컬렉션(시퀀스)에서 중복을 제거한 배열을 반환한다.

namespace LINQ_06_Distinct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1] Enumerable 타입의 중복된 숫자 3 제거
            var data = Enumerable.Repeat(3, 5); // 3을 5개를 가진 Enumerable 타입 반환
            var result = data.Distinct(); // 시퀀스에서 중복된 데이터 제거

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            // [2] 정수형 배열의 타입의 중복된 숫자 2, 3 제거
            int[] arr = { 2, 2, 3, 3, 4 };
            var r = arr.Distinct();

            foreach(var item in r)
            {
                Console.WriteLine(item);
            }
        }
    }
}
