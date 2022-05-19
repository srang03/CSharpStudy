using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 메서드와 마찬가지로 매개변수를 달리하여 하나의 클래스에 여러개의 생성자를 만들 수 있다.

namespace ConstructorOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructorLog cl = new ConstructorLog();
            ConstructorLog cl2 = new ConstructorLog("메세지");
        }
    }

    public class ConstructorLog
    {
        public ConstructorLog()
        {
            Console.WriteLine("기본 생성자");
        }

        public ConstructorLog(string msg)
        {
            Console.WriteLine("오버로드 생성자 : " + msg);
        }

    }
}
