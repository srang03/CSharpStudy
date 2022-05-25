using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // [1] 기본 : Item1, Item2
            var tuple = (12, 34, 56);
            Console.WriteLine(tuple.Item1);

            // [2] 이름지정 : 이름 : 값
            var fhd = (Width : 1920, Height : 1080);  
            Console.WriteLine($"{fhd.Width} * {fhd.Height}");

            // [3] 이름과 형식 지정
            (ushort Width, ushort Height) hd = (1366, 768);
            Console.WriteLine($"{hd.Width} * {hd.Height}");


            // [4]
            var t1 = Tally1();
            Console.WriteLine($"{t1.Item1} {t1.Item2}");

            var t2 = Tally2();
            Console.WriteLine($"{t2.X} {t2.Y}");

            var boy = (Name: "철수", IsStudent: true, OrderPrice: 1_000);
            Console.WriteLine($"{boy.Name} - 주문 {boy.OrderPrice:C0}");

            // [5]
            var zero = Zero();
            Console.WriteLine($"{zero.Item1}, {zero.Item2}");

            // [6] 튜플 분해, 튜플 해체 작업, 튜플 구조 분해, 파괴
            var (sum, count) = Tally();
            Console.WriteLine(sum);
            Console.WriteLine(count);
        }

        static (int s, int c) Tally()
        {
            var r = (s: 1, c: 2);
            return r;
        }

        // [4] 튜플 리턴 형식
        static (int, int) Tally1()
        {
            var r = (12, 3);
            return r;
        }

        static (int X, int Y) Tally2()
        {
            var r = (12,3);
            return r;
        }

        // [5] 튜플 기본값 초기화
        static (int, int) Zero() => default;
        // (0, 0)으로 반환


   
        

    }
}
