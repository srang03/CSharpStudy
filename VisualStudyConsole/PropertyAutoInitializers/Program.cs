using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAutoInitializers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.UserID );
        }
    }

    public class Person
    {
        public Guid UserID { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "이안";
    }
}
