using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스 생성시 단순하게 데이터를 입력하고 출력하는 것이 아니라
// 내가 원하는 T 타입으로 클래스를 사용할 수 있도록 한다.

namespace GenericNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1] 기본 타입의 리스트 생성
            List<string> colors = new List<string>() { "Red", "Blue" };
            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }

            // [2-1] 컬랙션 객체 초기화
            List<Person> people = new List<Person>()
            {
                new Person() { Name = "이안1"},
                new Person() { Name = "이안2"},
                new Person() { Name = "이안3"}
            };

            // [2-2]
            people.Add(new Person() { Name = "이안4" });

            // [2-3]
            var peoplePlust = new List<Person>() {
                new Person() { Name = "이안5" },
                new Person() { Name = "이안6" }
            };
            people.AddRange(peoplePlust);


            var categories = new List<Category>()
            {
                new Category() { CategoryId = 1, CategoryName = "책1"},
                new Category() { CategoryId = 2, CategoryName = "책2"},
                new Category() { CategoryId = 3, CategoryName = "책3"}
            };
            
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryId} - {category.CategoryName}");
            }
        }

    }

    // [2] 컬렉션 이니셜라이저 > 객체 초기화
    public class Person
    {
        public string Name { get; set; }
    }

    //[3] 모델 클래스 : Category, CategoryModel
    // 사용자가 직접 만든 데이터 타입 여러개의 값을 담을 수 있는 클래스를 생성하고
    // 그 클래스를 List<클래스> 형태로 묶어서 필요할 때 사용할 수 있도록 구현한다.
    // 모델 클래스 정의 > 객체 생성 

    public class Category
    {
        public int CategoryId { get; set; } 
        public string CategoryName { get; set; }
    }
}
