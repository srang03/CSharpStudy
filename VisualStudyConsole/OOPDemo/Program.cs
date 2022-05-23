using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo // 네임스페이스 : 클래스명의 충돌 방지 
{
    
    interface IStandard // 인터페이스 : 표준, 다중 상속
    {
        void run();
    }

    public class Car : IStandard
    {
        private Action<string> printf = Console.WriteLine;

        // 필드 : 부품
        #region 필드
        private string _name; // 일반 변수
        private string[] _options; // 배열
        private readonly int _Gas; // 읽기 전용 readonly
        #endregion

        // 속성
        #region 속성
        public int Number { get; private set; }
        public string Name { get; private set; }
        
        #endregion

        #region 생성자
        public Car(): this("기본 자동차")
        {

        }
        public Car (string name): this(name, 0)
        {
            
        }

        public Car (string name, int number)
        {
            this._name = name;
            this.Number = number;
            _options = new string[number];
        }
        #endregion

        #region 메서드
        // 클래스 메서드 구현
        public void On() => printf("시동 ON");

        // 인터페이스 메서드 구현
        public void run()
        {
            printf("달린다");
        }

        #endregion

        #region 소멸자
        ~Car() => printf("Car 객체 소멸");

        #endregion

        #region 인덱서
        public string this[int index]
        {
            get { return _options[index];  }
            set
            {
                if(index < Number && index > -1)
                    _options[index] = value;
            }
        }
        #endregion

        #region 이터레이터
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i<Number; i++)
            {
                yield return _options[i];
            }
        }
        #endregion

        #region 대리자
        public delegate void EventHandler(); // 대리자 : 동일한 함수 시그니처를 가진 메서드를 보관하고 있다가 나중에 호출한다.
        #endregion

        #region 이벤트 및 이벤트 핸들러
        // 이벤트 : delegate로 생성한 이벤트는 다중 메서드를 담고 있을 수 있다.
        public event EventHandler Click;

        // 이벤트 핸들러 : 이벤트 발생시 수행하는 메서드
        public void OnClick()
        {
            if (Click != null)
            {
                Click();
            }
        }
        #endregion
      
    }
    public class SuperCar : Car, IStandard
    {
        public new void run()
        {
            Console.WriteLine("슈퍼카 부릉");
        }
    }
    #region 다형성(융통성)
    class CarRepair
    {
        public CarRepair(IStandard car) => car.run();
    }
    #endregion

    class Program // 클래스 : 설계도
    {
        static void Main(string[] args)
        {
            Car car = new Car("아반떼", 2);
            SuperCar supercar = new SuperCar();
            Console.WriteLine(car.Number); 
            for(int i = 0; i<car.Number; i++)
            {
                car[i] = "옵션" + 1 + i;
            }

            foreach(string name in car)
            {
                Console.WriteLine(name);
            }

            car.Click += Car_Click;
            car.OnClick();
        }

        private static void Car_Click()
        {
            Console.WriteLine("클릭되었습니다");
        }
    }
}