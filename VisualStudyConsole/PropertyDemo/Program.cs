using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PropertyDemo
{
    public class Car
    {
        // [1] public 필드 (사용하지 않는다)
        public string name;

        // [2] getter, setter 메서드
        private string model;
        public string GetModel()
        {
            return model;
        }

        public void SetModel(string value)
        {
            this.model = value;
        }

        // [3] 전체 속성
        
        private string _carNumber;
        public string CarNumber {
            get // get 접근자, getter
            { 
                return _carNumber;
            }
            set // set 접근자. setter
            { 
                this._carNumber = value; 
            }
        }

        // [4] 속성 (계산식 추가 가능)
        private string _carName;
        public string CarName 
        {
            get
            {
                return "[" + _carName + "]"; 
            }
            set 
            { 
                this._carName = "[" + value + "]"; 
            }
        }


        // [5] 자동 완성 속성 (.NET 대문자로 시작)
        public string Name { get; set; }

        
    }
    // 속성 : 클래스 내부의 필드의 값을 읽거나 쓰거나 계산하는 방법을 제공하는 속성을 나타내는 맴버이다.
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.name = "My Car";
            Console.WriteLine(car1.name);

            car1.Name = "Your Car";
            Console.WriteLine(car1.Name);
        }
    }
}
