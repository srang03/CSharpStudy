using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionReview02
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
        }
    }

    public class Parent
    {
        public string Word { get; set; }
        public Parent(string word)
        {
            Word = word;
        }
    }

    public class Child : Parent
    {
        public Child() : this("기본 생성자") { }
        public Child(string word) : base(word) { }

        public void Say()
        {
            System.Console.WriteLine(Word);
        }
    }
}
