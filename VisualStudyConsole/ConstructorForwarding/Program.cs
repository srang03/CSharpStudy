using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorForwarding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Say say1 = new Say();
            Say say2 = new Say("[2] 반갑습니다.");

            Money money1 = new Money();
            Money money2 = new Money(2000);
        }

    }
    public class Say
    {
        private string message = "[1] 안녕하세요";
        public Say() => Console.WriteLine(this.message);

        // this() 생성자로 자신의 매개변수가 없는 생성자를 먼저 호출한다.
        public Say(string message): this()
        {
            // 매개변수가 있는 생성자 자체도 호출한다.
            this.message = message;
            Console.WriteLine(this.message);
        }
    }


    internal class Money
    {
        private int _Amount;
        public Money(): this(1000)
        {
            
        }

        public Money(int money)
        {
            _Amount = money;
            Console.WriteLine($"입급 : {_Amount}");
        }
    }
}
