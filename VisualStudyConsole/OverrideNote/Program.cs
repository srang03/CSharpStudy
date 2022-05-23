using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideNote
{
    public class Parent
    {
        public void Say() => Console.WriteLine("[p] : Say");
        public void Run() => Console.WriteLine("[p] : Run");
        public virtual void See() => Console.WriteLine("[p] : See");
    }

    public class Child : Parent
    {
        public void Say() => Console.WriteLine("[c] : Say");
        public new void Run() => Console.WriteLine("[c] : Run");
        public override void See() => Console.WriteLine("[c] : see");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Say();
            child.Run();
            child.See();    
        }
    }
}
