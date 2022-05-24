using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericWithLINQ
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Car> list = new List<Car>()
            { 
                new Car() { Make="현대", Model="소나타", Year = new DateTime(2020,01,01)}, 
                new Car() { Make="제네시스", Model="G80", Year = new DateTime(2018,09,30)}, 
                new Car() { Make="제네시스", Model="G70", Year = new DateTime(2020,10,11)}, 
                new Car() { Make="기아", Model="K5", Year = new DateTime(2021,07,21)}, 
                new Car() { Make="기아", Model="K3", Year = new DateTime(2018,02,07)}, 
                new Car() { Make="쉐보레", Model="크루저", Year = new DateTime(2019,04,01)}, 
                new Car() { Make="현대", Model="아반떼", Year = new DateTime(2016,02,05)}, 
                new Car() { Make="현대", Model="그렌저", Year = new DateTime(2020,03,03)}, 
            };

            // [1-1] Make가 현대인것만 출력 LINQ
            var 현대 = list.Where((car) => car.Make == "현대");
            
            foreach (var car in 현대)
            {
                Console.WriteLine(car.Model);
            }

            // [1-2] Make가 현대인것만 출력
            var 현대2 = from car in list
                      where car.Make == "현대"
                      select car;
            foreach (var car in 현대2)
            {
                Console.WriteLine(car.Model);
            }

            // [2] 2019년 이후 출시된 자동차
            var over2019 = list.Where((car) => car.Year.Year >= 2019);
            foreach (var car in over2019)
            {
                Console.WriteLine($"{car.Model} [{car.Year.Year}]");
            }

            var over20192 = from car in list where car.Year.Year >= 2019 select car;
            foreach (var car in over20192)
            {
                Console.WriteLine($"{car.Model} [{car.Year.Year}]");
            }

        }
    }
}
