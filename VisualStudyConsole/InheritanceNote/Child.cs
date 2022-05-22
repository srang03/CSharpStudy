using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNote
{
    class Child : Parents
    {
        public Child(string name) : base(name) { }
        public void Bar() => Console.WriteLine("Child");
    }
}
