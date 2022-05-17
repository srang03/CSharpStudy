using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);

 
            List<string> colors = new List<string>();

            // 값을 입력할 때 Add와 Insert 메서드 사용
            // 값을 출력할 때 (접근) Index 값으로 사용
            colors.Add("Black");
            colors.Add("White");
            colors.Insert(0, "Green");

            ShowAll(colors);
        }

        public static void ShowAll(List<string> list)
        {
            foreach(var n in list)
            {
                Console.WriteLine(n);
            }
        }
    }
}
