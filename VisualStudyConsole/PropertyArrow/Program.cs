using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyArrow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Count c = new Count();
            c.IncreaseCounter();
            c.IncreaseCounter();
            c.IncreaseCounter();
            Console.WriteLine(c.Counter);


            Person person = new Person();
            person.Name = "이안";
            person.Birthday = new DateTime(1995, 3, 3);
            Console.WriteLine(person.Age); 
        }
    }

    public class Count
    {
        private int _counter;

        public int Counter
        {
            get => _counter;
            set => _counter = value;
        }

        public void IncreaseCounter()
        {
            Counter++;
        }
    }

    public class Person
    {
        private string _name;
        private DateTime _birthday;

        public string Name
        {
            get => this._name;
            set => this._name = value;
        }

        public DateTime Birthday
        {
            get => this._birthday; 
            set => _birthday = value;
        }

        public int Age
        {
            get => (DateTime.Now.Year - _birthday.Year);
        }
    }
}
