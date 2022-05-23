#define RELEASE

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace AttributeDemo
{
    public class LuxuryAttribute : Attribute 
    {
        public LuxuryAttribute() => Console.WriteLine("Luxury 속성 생성");
    }
    
    [Luxury]
    class Car // API
    {
        [Obsolete("삭제된 메서드 입니다.", true)]
        public void Run() => Console.WriteLine("달리기");
        [Obsolete("다음 버전에 제거될 예정이니 Auto()를 사용해주세요.")] // 메뉴얼 메서드는 더이상 사용하지 않겠다.
        public void Manual() => Console.WriteLine("수동 운전");
        public void Auto() => Console.WriteLine("자동 운전");

        [Conditional("RELEASE")]
        public void RELEASE_Test() => Console.WriteLine("RELEASE 운전");
        [Conditional("DEBUG")]
        public void Test() => Console.WriteLine("테스트 운전");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car car = new Car(); // 자동차 객체 생성
            Attribute.GetCustomAttributes(typeof(Car));
            typeof(Car).GetCustomAttributes(false);

            // car.Run(); // [Obsolete("메시지", true)] 사용하지 못하도록 메시지와 true 값을 매개변수로 작성한다.
            car.Manual(); // [Obsolete] 속성이 적용된 메서드는 사용하지 않도록 권장하는 목적을 가진다.
            car.Auto();
            car.Test();
            car.RELEASE_Test();


            // 리플렉션
            var carType = (new Car());
            Type myCar = (carType).GetType();
            MethodInfo info = myCar.GetMethod("Auto");
            info.Invoke(carType,null);
        }
    }
}
