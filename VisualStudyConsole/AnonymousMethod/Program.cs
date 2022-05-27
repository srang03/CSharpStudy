using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    class Program
    {
        delegate void Deleagate2(string s);
        static void Main(string[] args)
        {
            // [1] 메서드 직접 호출
            Print.Show("안녕하세요");

            // [2] 대리자에 메서드 등록 후 호출
            Deleagate2 del = new Deleagate2(Print.Show);
            del.Invoke("하이");

            // [3] 무명 메서드 호출 : delegate 키워드로 무명 메서드 호출
            Deleagate2 del2 = delegate (string m) { Console.WriteLine(m); };

            del2.Invoke("또 만나요");

            ff("KBO", del2);
        }

        static void ff(string str, Deleagate2 del)
        {
            del = (string s) => { Console.WriteLine(s + "\n" + s); };
            del(str);
        }
    }

    public class Print
    {
        public static void Show(string msg) => Console.WriteLine(msg);
    }
}
