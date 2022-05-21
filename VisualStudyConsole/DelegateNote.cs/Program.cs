using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 대리자 : 매개 변수 목록 및 반환 형식이 있는 메서드 참조를 나타내는 형식으로
// 위임하다, 대신하다의 의미를 가지고 있다.
// 함수 자체를 데이터 하나로 보고 의미 있는 그대로 다른 메서드를 대신해서 실행하는 기능이다.

namespace DelegateNote.cs
{
    class Program
    {
        static void Hi() => Console.WriteLine("하이");
        static void Hello() => Console.WriteLine("헬로우");
        delegate void SaySomthing();
        delegate int IntDel(int x);

        static void Main(string[] args)
        {
            SaySomthing SS = Hi;
            SS();

            SS += Hello;
            SS -= Hi;

            SS.Invoke();

            SS = delegate () { Console.WriteLine("바이"); };
            SS.Invoke();

            SS = () => { Console.WriteLine("호이"); };
            SS.Invoke();

            IntDel del = new IntDel((int x)=> x*x);
            int res = del(2);
            Console.WriteLine(res);

            del = delegate (int x) { return x * 2; };
            res = del(3);
            Console.WriteLine(res);
        }
    }
    
}
