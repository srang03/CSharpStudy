using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1] throw 예외 던지기
            // throw (new ArgumentNullException()); // throw 키워드를 사용하여 인위적으로 에러를 발생시킬 수 있다.

            // [2] try catch
            try
            {
                // 예외가 발생할 구문
                int[] arr = { 1, 2, 3 };
                arr[100] = 1234;
            }
            catch
            {
                Console.WriteLine("에러가 발생했습니다.");
                // 에러가 발생했지만 정상 종료 시켜준다.
            }

            // [3] catch (Exception ex)
            try
            {
                int[] arr = new int[] { 1, 2, 3 };
                arr[100] = 1234;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            // [4] FormatException

            string inputNumber = "1.234";
            int number = 0;
            try
            {
                number = Convert.ToInt32(inputNumber);
                Console.WriteLine($"입력한 값 : {number}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"에러발생 : {ex.Message}");
            }

            // Try Catch 문이 중요한 이유는 언제 예외가 발생할지 모르기 때문이다.
        }
    }
}

