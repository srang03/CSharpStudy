using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1] XML 요소 생성
            XElement category = new XElement("MENUS",
                new XElement("Menu", "책"),
                new XElement("Menu", "강의"),
                new XElement("Menu", "컴퓨터")
            );

            Console.WriteLine(category);

            // [2] XML 요소 가공
            XElement newCategory = new XElement("MENUS",
                from node in category.Elements() where node.Value.ToString().Length > 2 select node
            );

            Console.WriteLine(newCategory);
        }
    }
}
