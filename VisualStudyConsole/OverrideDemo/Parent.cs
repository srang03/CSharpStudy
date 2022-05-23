using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideDemo
{
    internal class Parent
    {
        protected void Say() => Console.WriteLine("[parent] : 안녕하세요");
        protected void Run() => Console.WriteLine("[parent] : Run");
        public virtual void Walk() => Console.WriteLine("[parent] : Walk");
        public virtual void Work() => Console.WriteLine("[parent] : Work..");
    }
}
