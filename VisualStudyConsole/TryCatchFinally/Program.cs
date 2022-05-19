using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    internal class Program
    {
   

        
        static void Main(string[] args)
        {
            int x = 5;
            int y = 0;
            int result;

            try // 예외가 발생할 가능성이 있는 구문
            {
                result = x / y; // 무조건 예외 발생 
                Console.WriteLine($"x / y = {result}");
            }
            catch (Exception ex) // 예외 발생시 실행
            {
                Console.WriteLine("에러 메세지 : {0}", ex.Message); 
            }
            finally // 예외가 발생하던 안하던 실행
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
