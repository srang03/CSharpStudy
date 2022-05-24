using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraint
{
    public class CarValue<T> where T : struct { } // 값 형식의 제약 조건
    public class CarType<T> where T : new() { } // 기본 생성자가 있는 객체

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
