using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Say(); // 자식이 예의가 없는 경우 (부모 : X,  자식 : X)
            child.Run(); // 자식이 예의가 있는 경우 (부모 : X,  자식 : new)
            child.Walk(); // (부모 : virtual, 자식 : override) base 기능 실행
            child.Work(); // (부모 : virtual, 자식 : override) 재정의

        }
    }
}
