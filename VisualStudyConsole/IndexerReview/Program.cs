using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 인덱서 : 클래스의 인스턴스를 배열처럼 "객체[인덱스]" 형태로 사용할 수 있는 구문
//          속성의 확장한 형태로 속성들의 값을 초기화하거나 접근할 수 있는 기능을 제공한다.


namespace IndexerReview
{
    class Program
    {
        static void Main(string[] args)
        {
            IsEven isEven = new IsEven();
            Console.WriteLine(isEven[1]);

            Car car = new Car(3);
            car[0] = "열선";
            car[1] = "후방 카메라";
            car[2] = "자동주행";

            for(int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }

            Week week = new Week();
            week[0] = "월요일";
            week[1] = "화요일";
            week[2] = "수요일";

            Console.WriteLine(week[0]);
            Console.WriteLine(week[1]);
            Console.WriteLine(week[2]);
        }
    }
    public class Week
    {
        private string[] _week;

        public int Length
        {
            get; private set;
        }

        public Week()
        {
            Length = 7;
            _week = new string[Length];
        }

        public string this[int index]
        {
            get { return _week[index];  }
            set { _week[index] = value;  }
        }
    }
    #region IsEven 클래스
    public class IsEven
    {
        public bool this[int index]
        {
            get
            {
                return index % 2 == 0;
            }
        }
    }
    #endregion
    #region Car 클래스
    public class Car
    {
        private string[] _options;


        public Car() : this(0) { }

        public Car(int length)
        {
            Length = length;
            this._options = new string[length];
        }

        public int Length
        {
            get; private set;
        }

        public string this[int index]
        {
            get
            {
                if (index > -1 && index < Length) return _options[index];
                else return "잘못된 접근입니다.";
            }
            set
            {
                if (index > -1 && index < Length) this._options[index] = value;
            }
        }
    }
    #endregion
}
