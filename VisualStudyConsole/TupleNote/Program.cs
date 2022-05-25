using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = GetNotes();
            Console.WriteLine($"{a.x}, {a.y}");

            var b = (1, 2, 3);
            Console.WriteLine($"{b.Item1}, {b.Item2}, {b.Item3}");

            var c = Tally1();
            Console.WriteLine($"{c.Item1}, {c.Item2}");
            var d = Tally2();
            Console.WriteLine($"{d.Sum}, {d.Count}");

            // [3] 이름이 지정된 튜플
            var boy = (Name: "이안", Age: 27, Option: true);
            Console.WriteLine($"{boy.Name}, {boy.Age}, {boy.Option}");

            var e = Zero();
            Console.WriteLine($"{e.Item1}, {e.Item2}");

            var (x, y, z) = b;
            Console.WriteLine($"{x}, {y}, {z}");


        }

        // [1] 일반적인 튜플 사용
        static (int x, int y) GetNotes()
        {
            return (10, 20);
        }

        // [2] 튜플 반환
        // 한 번에 하나 이상을 반환시켜주는 기능을 튜플 반환이라고 한다.
        // 튜플 반환에는 튜플 리터럴을 사용합니다.
        static (int, int) Tally1()
        {
            return (12, 3);
        }

        static (int Sum, int Count) Tally2()
        {
            return (42, 4);
        }

        // [4] 튜플 반환값에 기본값 설정
        static (int, int) Zero() => default;

    }
}
