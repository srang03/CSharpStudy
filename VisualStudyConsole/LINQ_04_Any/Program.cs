using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ Any 확장 메서드 : 시퀀스에 조건에 만족하는 요소가 하나라도 있으면 true 반환, 없으면 false 반환
namespace LINQ_04_Any
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            // arr 배열의 요소들 중 짝수가 존재하면 true, 존재하지 않는다면 false 반환
            bool res = arr.Any(x => x % 2 == 0); // bool 반환

            if (res)
                Console.WriteLine("짝수가 존재합니다.");
    
            else
                Console.WriteLine("짝수가 존재하지 않습니다.");
        }
    }
}
