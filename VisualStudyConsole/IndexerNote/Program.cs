using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerNote
{
    class Program
    {
        static void Main(string[] args)
        {
            // [1]
            Category category = new Category();
            Console.WriteLine(category[20]);

            // [2]
            Developer developer = new Developer();
            developer[0] = "이안";
            Console.WriteLine(developer[30]);

            // [3]
            Car car = new Car(10);
            car[0] = "쏘나타";
            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);

            // [4]
            Week week = new Week(3);
            week[0] = "월요일";
            week[1] = "화요일";
            week[2] = "수요일";

            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine(week[i]);
            }

            // [5]
            NickName nickName = new NickName();
            nickName["Name"] = "이안";
            Console.WriteLine(nickName["Name"]);
            Console.WriteLine(nickName["Name2"]);
        }   
    }

    // [1] 정수 인덱서
    class Category
    {
        public string this[int index]
        {
            get { return index % 2 == 0 ? "짝수" : "홀수"; }
        }
    }

    // [2] 인덱서를 사용하여 여러 값 주고받기
    class Developer
    {
        private string name;
        public string this[int index]
        {
            get { return name; }
            set { name = value;  }
        }
    }

    // [3] 인덱서를 사용하여 배열 형식의 객체 만들기
    public class Car
    {
        private string[] names;

        public Car(int length)
        {
            names = new string[length];
        }

        public int Length
        {
            get; private set;
        }

        public string this[int index]
        {
            get { return this.names[index]; }
            set { this.names[index] = value;  }
        }
    }

    // [4] 배열 형식의 필드를 사용하는 인덱서
    public class Week
    {
        private string[] _week;
        public int Length
        {
            get;
        }

        public Week()
        {
            Length = 7;
            _week = new string[Length];
        }
        
        public Week(int length)
        {
            this.Length = length;
            _week = new string[Length];
        }

        public string this[int index]
        {
            get { return _week[index]; }
            set { this._week[index] = value; }
        }
    
    }

    // [5] 문자열 매개변수를 받는 인덱서 사용하기
    public class NickName
    {
        private Hashtable _names = new Hashtable();

        public string this[string key]
        {
            get { return _names[key].ToString(); }
            set { this._names[key] = value;  }
        }
    }

}
