using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    public class Car
    {
        private string _name;
        private int _number;
        public Car() : this("기본 자동차", 0000)
        {
            // 매개변수와 반환값이 없는 특별한 메서드
            //Console.WriteLine("[1] The Car is created");
            // 기본 생성자 Body
        }
        public Car(string name) : this(name, 0000) => Console.WriteLine("차량번호 미등록");

        public Car(string name, int Number) 
        {
            Console.WriteLine("[1] 시동");
            this._name = name; // this.필드 = 매개 변수
        }

        public void Go() => Console.WriteLine($"[2] {this._name} 출발 Run..");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); // 참조 연산자 new 사용, 생성자 Car() 호출
            car.Go();
            
            Car MyCar = new Car("제네시스", 4322);
            MyCar.Go();

        }
    }
}
