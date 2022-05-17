using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // throw new Exception();
            // throw new ArgumentException();

            // Exception 클래스는 예외 관련 부모 클래스
            // 카테고리별로 예외 클래스 사용 가능

            Console.WriteLine("[1] 프로그램 시작");

            // try : 에러가 발생할만한 코드 들어오는 영역
            try
            {
                Console.WriteLine("[2] 동작 실행");
                throw new Exception("내가 만든 에러"); // 무조건 에러 발생
            } 
            catch (Exception e)
            {
                // try 절에서 예외가 발생하면 catch 절에서 수행
                
                Console.WriteLine($"[2-1] 예외처리 : {e.Message}");
            }

            // try절에서 에러가 발생하던 안하던 반드시 실행하는 영역 (예외처리 마무리 영역)
            finally
            {
                Console.WriteLine("[3] 종료");
            }

        }
    }
}
