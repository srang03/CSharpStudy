using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideDemo
{
    internal class Child : Parent
    {
        public void Say() => Console.WriteLine("[child] : 안녕하세요");
        public new void Run() => Console.WriteLine("[child] : Run");
        public override void Walk()
        {
            base.Walk(); // 부모를 따르다.
        }

        public override void Work()
        {
            Console.WriteLine("[child] : Play");
        }
    }
}
