using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public abstract class CarBase
        // 추상 클래스는 상속시킬 목적으로 base 역할을 수행한다.
    {
        public abstract void Left(); // 추상 클래스의 추상 메서드, 시그니처로 표준(강제성)의 역할을 수행한다. => 인터페이스
        public void Back() => Console.WriteLine("Back ...");
        protected string Parking { get; private set; } = "Parking"; // 자식에게만 맴버 노출
    }
    public enum CarType { 전기, 내연기관, 수소 }
    // 사용자 정의 클래스는 Object 클래스르 상속 받는다.
    public class Car : CarBase
    {
        public CarType Type { get; private set; } // 공통 관리 속성

        // 일반적으로 부모 클래스에는 공통 기능 구현
        public void Go() => Console.WriteLine("Run...");

        public override void Left() // 재정의 실제 코드 구현
        {
            Console.WriteLine("Left...");
            Console.WriteLine(base.Parking); 
        }

        public Car(CarType type)
        {
            this.Type = type;
        }
        
    }

    public class Benz : Car // Sub Class : Base Class 
    {
        // 자식 클래스의 목적에 맞는 기능 구현 
        public Benz() : base(CarType.내연기관) { }
        public Benz(CarType type) : base(type){}
        // 초기화 방법 2개 선언시 초기화해줄 수 있고, 생성자 호출시 초기화해줄 수 있다.
       
        public void Print() => Console.WriteLine(base.Parking);
    }

    public class Tesla : Car
    {
        public Tesla() : base(CarType.전기) { }
        public Tesla(CarType type) : base(type) { }
      
    }

    // Object 클래스로부터 모든 기능을 상속받는다. ( : Object는 생략)
    class InheritanceDemo :Object
    {
        static void Main()
        {

            Car car = new Car(CarType.내연기관);
            Benz benz = new Benz();
            benz.Go();
            Console.WriteLine(benz.Type);
            benz.Back();
            
            Tesla tesla = new Tesla();
            Console.WriteLine(tesla.Type);

            Future future = new Future();
            Console.WriteLine(future.Type);
            future.Go();
            
            
        }
    }

    //public  class OtherFuture : Future // 오류 발생
    //{

    //}

    // 상속 금지, 봉인 클래스, 최종 클래스
    public sealed class Future : Car
    {

        public Future() : base(CarType.수소)
        {
                
        }
        public Future(CarType type) : base(type)
        {

        }

        // new 연산자를 붙여서 
        public new void Go()
        {
            //base.Go(); 
            Console.WriteLine("Fly...");
        }
    }
}
