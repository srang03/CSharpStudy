using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideReivew
{
    class Program
    {
        static void Main(string[] args)
        {
            ParentClass pc = new ChildClass();
            pc.Hi();
            pc.Bye();
            pc.GO();
        }
    }


    public class ParentClass
    {
        public virtual void Hi() => System.Console.WriteLine("안녕하세요");
        public void Bye() => System.Console.WriteLine("잘가");
        public void GO() => System.Console.WriteLine("가다");
    }

    public class ChildClass : ParentClass
    {
        private string name = "파생";
        public override void Hi()
        {
            System.Console.WriteLine($"{name} : 안녕하세요");
        }
        public new void Bye() => System.Console.WriteLine($"{name} : 잘가");
        public new void GO() => System.Console.WriteLine($"{name} : 가다");
    }

}
