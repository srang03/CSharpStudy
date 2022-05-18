using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditional
{

    // 널 조건부 연산자 (Null Conditional Operator) : ?. > 엘비스 연산자
    // null 값이면 null 값을 반환하고, null 값이 아니면 연산자 뒤에 속성을 반환한다.
    internal class Program
    {
        static void Main(string[] args)
        {
            int? len;
            string message = null;

            //len = message.Length; // null일 경우 에러 발생
            
            len = message?.Length; // 엘비스 연산자 사용

            
            if(len == null)
            {
                Console.WriteLine("[1] message null 입니다.");
            }


            // len = message?.Length ?? 0; 널 조건부 연산자(엘비스 연산자)와 복합 연산자 혼합 사용


            message = "안녕";
            len = message?.Length;

            if(len != null)
            {
                Console.WriteLine($"[2] message는 {len}자 입니다.");
            }
            
           
        }
    }
}
