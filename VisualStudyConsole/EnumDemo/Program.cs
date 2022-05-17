using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 하나의 이름으로 여러개의 데이터를 관리할때 배열, 구조체, 클래스, 열거형를 사용한다.
// 열거형의 목적은 부모의 열거이름만 알면 편리하게 데이터 리스트를 확인하고 사용할 수 있다.
namespace EnumDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ConsoleColor는 열거형 타입으로 색상을 가지고 있는 데이터 타입이다.

            // Console창의 ForegroundColor 설정
            Console.ForegroundColor = ConsoleColor.Red;

            // Console창에 설정된 ForegroundColor 초기화
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine($"Background : {nameof(ConsoleColor.White)}");

         

        }
    }
}
