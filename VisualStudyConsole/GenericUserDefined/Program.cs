using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUserDefined
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new Cup<String>("Hello");
            Console.WriteLine(text.Content);

            var number = new Cup<int>(123);
            Console.WriteLine(number.Content);
            
            var value = new Person() { Name = "이안", Age = 27 };
            Cup<Person> person = new Cup<Person>(value);

            Console.WriteLine($"{person.Content.Name} - {person.Content.Age}");
        }
    }
    public class Cup<T> 
    {
        public T Content { get; set; }

        public Cup(T str)
        {
            Content = str;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    
}
