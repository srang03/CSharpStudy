using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 읽기 전용 필드를 사용하고, 필드의 값을 변경하고 싶을 경우 생성자를 통해서 변경할 수 있도록 구현한다.
            Point point = new Point(0, 1);
            Console.WriteLine($"{point.x}, {point.y}");

            // 메서드 체이닝
            Point point2 = new Point(0, 0).MoveBy(1, 2).MoveBy(2, 3);
            Console.WriteLine($"{point2.x}, {point2.y}");

        }
    }

    public class Point
    {
        public readonly int x;
        public readonly int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // [1] 생성자 반환값을 나 자신(Point)으로 지정
        // 반환값 자체가 나자신
        // 반환값 자체가 나의 또다른 인스턴스를 반환한다.
        // 재귀 형태의 코드

        public Point MoveBy(int dx, int dy)
        {
            return new Point(x + dx, y + dy);
            
        }
    }
}
