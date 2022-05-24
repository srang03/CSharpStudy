using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ (Language INtegrate Query) 
namespace GenericLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 컬렉션에 담기
            List<Car> cars = new List<Car>()
            {
                new Car() { Make  = "BMW", Model ="BMW3", Year = 2010 },
                new Car() { Make  = "BMW", Model ="BMW1", Year = 2011 },
                new Car() { Make  = "Benz", Model ="C", Year = 2012 },
                new Car() { Make  = "Benz", Model ="E", Year = 2013 },
                new Car() { Make  = "Benz", Model ="S", Year = 2014 }
            };

            // 전체 출력
            //for (int i = 0; i < cars.Count; i++)
            //{
            //    Console.WriteLine($"{cars[i].Make} {cars[i].Model} {cars[i].Year}"); 
            //}

            // LINQ 사용해서 Make가 BMW 인것만 출력
            var a = cars.Where(car => car.Make == "BMW");
            var b = from car in cars 
                    where car.Make == "BMW" select car;

            foreach (var item in a)
            {
                Console.WriteLine($"{item.Make} {item.Model} {item.Year}");
            }

            // 가장 최근에 출시된 자동차 정렬
            var c = from car in cars orderby car.Year descending select car;
            var d = cars.Where(car => car.Make == "BMW").OrderByDescending(car => car.Year);

            foreach (var item in d)
            {
                Console.WriteLine($"{item.Make} {item.Model} {item.Year}");
            }
        } 
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
