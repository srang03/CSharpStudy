using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassDemo
{
    public class People
    {
        private string _name;
        public string Name { get { return _name; } private set { _name = value;  } }

        public People(string name)
        {
            Name = name; 
        }

     }

    public class Category
    {
        public int Id { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var categories = new List<Category>()
            {
                new Category() { Id = 1 },
                new Category() { Id = 2 },
                new Category() { Id = 3 }
            };

            foreach(var category in categories)
            {
                Console.WriteLine(category.Id);
            }
        }
    }
}
