using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoReview
{
    class Program
    {
        // 매개변수도 없고 반환값도 없는 함수이다.
        // 동일한 형태의 함수를 대신 호출 해줄 수 있는 대리자는 delegate void 함수이름(); 구현할 수 있다.
        // 대리자의 첫 번째 목적은 이미 있는 함수를 대신 호출하는 것이다.

        static double PI = 3.141592;
        static void Hi() => Console.WriteLine("Hi"); 
        static void Bye() => Console.WriteLine("Bye");
        static double GetArea(int r)
        {
            return r * r * PI;
        }

        delegate void DelegateFunc();

        delegate double GetAreaPointer(int r);

        static void Main(string[] args)
        {
            // [1] 메서드 대신 호출
            var func = new DelegateFunc(Hi);
            func();

            // [2] 메서드 대신 호출
            DelegateFunc delegateFunc = new DelegateFunc(Hi);
            delegateFunc.Invoke();

            delegateFunc = Bye;
            delegateFunc.Invoke();
            // [3] 매개변수와 반환값이 있는 메서드 대신 호출
            var func2 = new GetAreaPointer(GetArea);
            double result = func2(3);
            Console.WriteLine(result);

            // [4] 이름 없는 메서드 호출 
            // 무명 메서드 delegate 키워드를 생성
            DelegateFunc func3 = delegate ()
            {
                Console.WriteLine("아무것도 없는 함수");
            };

            func3();

            // [5] 함수 포인터
            Whats whats = delegate { Console.WriteLine("함수 포인터 형식"); };
            Whats2 whats2 = delegate (int x) { return x * x; };

            whats();
            Console.WriteLine(whats2(2)); 
        }

        // [5] 함수 포인터
        public delegate void Whats();
        public delegate int Whats2(int x);
    
    }
}
