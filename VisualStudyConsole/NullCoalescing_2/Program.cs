using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCoalescing_2
{
    // null 병합 연산자
    // ?? 연산자 : 컬렉션이 null이 아니면 해당 값을 반환하고, null일 경우 뒤에 지정한 값을 반환한다.
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = null;
            int num;

            // [1] 리스트가 null이면 0으로 초기화
            num = list?.Count ?? 0; // null이면 0을 반환한다. 오른쪽 값 사용
            Console.WriteLine($"[1] 컬렉션 카운트 : {num}");

            list = new List<string>();
            list.Add("하이"); list.Add("바이");
            
            
            // [2] 리스트가 null이 아니면 해당 값으로 초기화
            num = list?.Count ?? 0; // null이 아니므로 Count 속성 값 반환, 왼쪽 값 사용
            Console.WriteLine($"[2] 컬렉션 카운트 : {num}");
        }
    }
}
