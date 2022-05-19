using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.ShowProfile();
        }
    }
    public class Person
    {
        private string name = "이안";
        private const int m_age = 27;
        private readonly string _NickName = "Ian";
        private string[] _Stack = { "ASP.NET", "C#", "JS", "Git" };

        private object all = DateTime.Now.ToShortDateString();

        public void ShowProfile()
        {
            string r = $"[{all}] {name}, {m_age}, {_NickName}, {String.Join(", ", _Stack)}";
            Console.WriteLine(r);
        }

    }
}
