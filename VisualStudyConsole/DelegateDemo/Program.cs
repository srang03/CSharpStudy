using System;

// [1] 대리자 (Delegate) : 함수 포인터 개념으로 메서드를 대신 호출해주는 기능이다.

class DelegateDemo
{
    static void GoForward() => Console.WriteLine("Go Forward");
    static void GoBack() => Console.WriteLine("Go Back");
    static void GoLeft() => Console.WriteLine("Go Left");
    delegate void Drive(); // (대리자 형식 생성) 어떠한 함수를 Drive()로 대신 호출해주겠다.

    static void Main(string[] args)
    {
        // GoForward(); // [1] 내가 직접 호출했다. 
        Drive drive = new Drive(GoForward);
        drive.Invoke(); // .Invoke() 생략가능

        drive += GoBack;
        drive();

        drive = delegate () { Console.WriteLine("좌회전"); };
        drive = () => { Console.WriteLine("우회전"); };
        drive();

        Action action = () => { Console.WriteLine("drive"); };
        action.Invoke();

        RunLamda(() => { Console.WriteLine("메서드의 매개변수로 함수 자체를 전달"); });

        Action<string> printf = Console.WriteLine;
        printf("Hello");
    }

    static void RunLamda(Action action) => action.Invoke();
    
}