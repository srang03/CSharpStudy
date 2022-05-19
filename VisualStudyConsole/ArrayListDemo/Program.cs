using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(100);
            list.Add(100);
            list.RemoveAt(1);

            list.Add(200);

            ShowAll(list);
        }

        static void ShowAll(ArrayList list)
        {
            foreach(var v in list)
            {
                Console.WriteLine(v);
            }
        }
    }
}
