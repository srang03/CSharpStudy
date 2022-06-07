using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerReview220605
{
    public class Car
    {
        private string[] options;

        public Car(int length = 1 )
        {
            options = new string[length];
        }

        public int Length
        {
            get { return options.Length; }
        }

        public string this[int index]
        {
            get { return options[index];  }
            set { if (index < Length) options[index] = value;  }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(2);
            car[0] = "자동 운전";
            car[1] = "열선 시트";

            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
        }
    }
}
