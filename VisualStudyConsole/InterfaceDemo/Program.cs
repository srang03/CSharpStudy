using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    // 인터페이스 선언
    public interface ICar
    {
        // 매개 변수도 없고 반환 값도 없는 Go() 메서드 시그니처 선언
        void Go();
    }

    // ICar 인터페이스 선언
    public class Car : ICar
    {
        // 상속한 인터페이스에 정의된 메서드를 구현
        public void Go()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
