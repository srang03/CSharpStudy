using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string message = "Hello world";

            Console.WriteLine(message.ToUpper()); // 대문자 변경
                                                  // .NET 프레임워크에 내장되어 있는 클래스 중에서 문자여 관련 클래스는 길이 반환, 문자열의 공백 제거, 대/소문자로의 변환 기능 제공
                                                  // C#의 문자열은 유니코드(Unicode) 문자열이므로 다국어를 지원하고 문자열 관련 모든 기능도 다국어를 제대로 처리한다.

            // String 클래스와 StringBuilder 클래스 사용
            // 보통은 String 클래스를 많이 사용하지만, 성능적인 이슈로 StringBuilder 클래스를 사용할 수 있다.


            // [1] 문자열 생성
            String s1 = "안녕하세요"; // String 클래스
            string s2 = "반갑습니다."; // string 키워드

            // [2] 문자열 연결 : 더하기 연산자, String.Concat()
            string s3 = "안녕" + "하세요";

            string s4 = "안녕";
            string s5 = String.Concat("하세요", s4);


            // [3] 문자열 길이 : String.Length 속성
            string s6 = "헬로우";
            Console.WriteLine(s6.Length.ToString());

            // [4] 문자열을 문자 배열로 변환하기 ToCharArray()
            string s7 = "ABCD";
            char[] c = s7.ToCharArray();

            foreach (char ch in c)
            {
                Console.WriteLine(ch);
            }

            // [5] 문자열 묶는 3가지 표현 방법 정리
            var FullName = "";
            var FirstName = "길동";
            var LastName = "홍";

                // #1 더하기 연산자
                FullName = FirstName + " " + LastName;

                // #2 String.Format() 메서드
                FullName = String.Format("{0} {1}", FirstName, LastName);

                // #3 믄지얄 보간법 사용
                FullName = $"{FirstName} {LastName}";

            // [6] 문자열 비교
            string userName = "RedPlus";
            string userNameInput = "redPlus";

                // 대소문자 구분 안함
            if(userName.ToLower() == userNameInput.ToLower())
            {
                Console.WriteLine("아이디가 동일합니다.");
            }

                // 문자열 비교시 사용 권장 (성능 조금 더 빠름)
                // Equals 메서드의 3번째 인자로 StringComparison 클래스의 옵션 사용가능
            if(String.Equals(userName, userNameInput, 
                StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("아이디가 동일합니다.");
            }

            // [7] 문자열의 대소문자 비교
            string s10 = "Gilbut";
            string s20 = "gilbut";

            if (s10.Equals(s20, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("아이디가 동일합니다.");
            }



        }
    }
}
