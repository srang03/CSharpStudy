using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullhandeler
{
    class Program
    {
        static void Main(string[] args)
        {
            // [1] null 사용
            int a = 10; // Value 타입
            string str = null; // Reference 타입
            // Reference Type은 null 값을 가질 수 있다.
            // Value Type은 null 값을 가질 수 없다.

            // [2] null 구조체
            Nullable<bool> bln = false;
            Console.WriteLine(bln.HasValue);

            // [3] null 허용 타입
            // nullable 형식
            int? nullableInt = null; // int?, double? 사용을 권장한다.

            // [4] null값 처리 연산자
            // ?? 연산자 (널 병함 연산자 Null coalescing Operator
           
            string message = str ?? "초기화";
            // str이 null 값이면 "초기화" 입력, null 값이 아니면 str값 입력
            Console.WriteLine(message);


            int? value = null;
            int defaultValue = value ?? -1;

            // [5] default 키워드 이용한 초기화
            int y = value ?? 100;
            int z = value ?? default(int); // 정수형의 기본값인 0으로 초기화
            // int x = value ?? default; // 정수형의 기본값인 0으로 초기화

            // [6] null 조건부 연산자 (Null Conditional)
            double? d = null;
            d?.ToString(); // 엘비스 연산자
            // d가 null이 아니면 string으로 변경, null이면 그대로
            d = 1.23;
            Console.WriteLine(d?.ToString()); // 1.23
            Console.WriteLine(d?.ToString("#.000")); // 1.230

            //[7] 널 병합 연산자와 널 조건부 연산자 함께 사용하기
            int num;
            List<string> list;

            // #1 컬렉션 리스트가 null이면 Count를 읽을 수 없기때문에 0으로 초기화
            list = null;
            num = list?.Count ?? 0; // null이면 0반환 오른쪽 값 사용
        }
    }
}
