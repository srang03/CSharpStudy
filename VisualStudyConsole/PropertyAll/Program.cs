using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            // [1] Getter와 Setter
            car1.SetColor("Red");
            Console.WriteLine(car1.GetColor());

            // [2] 속성 사용
            Car WhiteCar = new Car();
            WhiteCar.Color = "White";
            Console.WriteLine(WhiteCar.Color);

            // [3] 읽기 전용 속성
            Car car2 = new Car();
            Console.WriteLine(car2.Maker);

            // [4] 쓰기 전용 속성
            Car car3 = new Car();
            car3.Type = "준중형";

            // [5] 축약형 속성
            Car myCar = new Car();
            myCar.Name = "아반떼";
            Console.WriteLine(myCar.Name);
        }
    }

    public class Car
    {
        public string color; // 필드

        public Car() // 생성자
        {
            this.color = "Black";
        }

        public void SetColor (string color) // Setter
        {
            this.color = color;
        }

        public string GetColor() // Getter
        {
            return this.color;
        }

        // 전체 속성
         public string Color {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        // 읽기전용
        public string Maker
        {
            get
            {
                return "현대자동차";
            }
        }

        private string _Type;

        public string Type
        {
            set
            {
                this._Type = value;
            }
        }

        public string Name { get; set; }
    }
}
