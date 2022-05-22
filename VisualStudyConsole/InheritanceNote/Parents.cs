using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNote
{
    class Parents
    {
        public string Name { get; private set; }

        public Parents(string Name)
        {
            this.Name = Name;
        }

        public Parents SetName(string name)
        {
            return new Parents(name);
        }

        public void Foo() => Console.WriteLine("Parents");
    }
}
