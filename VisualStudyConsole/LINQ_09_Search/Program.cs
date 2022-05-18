using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_09_Search
{
    // 문자열.Contains() 메서드와 Where()메서드를 사용해서 원하는 조건의 요소를 찾을 수 있는 기능 구현이 가능하다. 
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // [3] 문자열 "e" 값을 가지는 요소만 리턴
            var colors = new List<string> { "Red", "Green", "Blue", "Black"};
            var newColors = colors.Where(c => c.Contains("e"));

            foreach (var item in newColors)
            {
                Console.WriteLine(item);
            }

            // [2] 문자열 "ee" 값을 가지는 요소만 리턴
            var green = colors.Where(c => c.Contains("ee"));

            foreach (var item in green)
            {
                Console.WriteLine(item);
            }

            // [3] 찾고자 하는 키워드 문자열과 리스트를 받아 해당 키워드를 포함하는 요소 리스트를 반환
            var contains_B = Search("B", colors);
            foreach (var item in contains_B)
            {
                Console.WriteLine(item);
            }
        }

        static List<string> Search(string word, List<string> list)
        {
            var result = new List<string>();

            result = list.Where(c => c.Contains(word)).ToList();

            return result;
        }
    }
}
