using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAnonymousClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // [1] 익명 형식으로 객체를 생성하고 속성 초기화
            var presenter = new { Name="Ian", age = 28};

            Console.WriteLine(presenter.Name);

            // [2] 덕 타이핑 
            presenter = new { Name = "Son", age = 31 };

            // [3] 유효성 검사 구현

            try
            {
                Car car = new Car("자동차");
                Console.WriteLine(car.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine("예외발생");
            }


            
        }
    }

    public class Car
    {
     
        public string Name { get; private set; }
        public Car (string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException();
            }
            this.Name = name;
        }
    }

    
}
