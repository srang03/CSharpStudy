using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FieldDemo;

public class Say
{
    private string message = "Hello";
    public void Hi() => Console.WriteLine(this.message); // this는 자기 자신의 인스턴스를 나타낸다.
}

public class Program
{
    private static string message = "안녕하세요"; // 전역 변수 : 메서드와 같은 레벨인 필드
    public static void Hi() => Console.WriteLine(message);
    public static void Main(string[] args)
    {
        int number = 4_321_234; // 지역 변수 : 메서드 안에 있는 변수
        Console.WriteLine(number);
        Console.WriteLine(message);
        Hi();

        Say say = new Say();
        say.Hi();

        Car car = new Car();
        Console.WriteLine(car.GetColor());
    }
}

