using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionNote
{
    public static class Extensions
    {
           public static string Three(this string value)
        {
            return value.Substring(0, 3);
        }
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Count();
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine(str.Three());

            string str2 = "안녕하세요. 반갑습니다 하이   하이...";
            Console.WriteLine(str2.WordCount()); 
        }
    }
}
