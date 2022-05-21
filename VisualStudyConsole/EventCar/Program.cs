using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("아반떼");
            car.Alert += SetAlert;
            car.ZeroAlert += SetZeroAlert;
            car.Run();
            car.Run();
            car.Run();
            car.Run();
            car.Run();
            car.Run();

        }
        static void SetAlert() => Console.WriteLine("주유가 필요합니다.");
        static void SetZeroAlert() => Console.WriteLine($"달릴 수 없습니다. ");
    }
    public class Car
    {
        private string _name;
        private int _gas;

        public string Name { get;  }
        public int Gas 
            {
            get
            {
                return this._gas;
            }
            set
            {
                if(value < 1)
                {
                    ExecuteZeroAlert();
                    this._gas = 0;
                }
                else
                {
                    this._gas = value;
                    ExecuteAlert();
                }
          
            }
        }

        public delegate void EventHandler();
        public event EventHandler Alert;
        public event EventHandler ZeroAlert;

        public Car(string name)
        {
            this._name = name;
            this._gas = 30;
        }
        public void ExecuteZeroAlert()
        {
                ZeroAlert?.Invoke();
                return;
        }
        public void ExecuteAlert()
        {
           
            if (Gas < 30)
            {
                Alert?.Invoke();
                return;
            }
           
        }


        public void Run()
        {
            Gas -= 10;
            Console.WriteLine($"자동차가 달립니다 [남은 기름 : {Gas}]");
           
        }

    }
}
