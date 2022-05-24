using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1] 문자열 배열 선언
            var a1 = new string[] { "Red", "Blue", "Yellow" };
            
            // [2] List<string> 객체를 생성 후 문자열 배열을 ToList() 메서드로 변환
            var a2 = new List<string>();
            a2 = a1.ToList();

            // [3] IEnumerable<T> 객체를 생성한 후 문자열 배열을 바로 대입 가능
            IEnumerable<string> a3 = a1;

            // [3] IEnumerable<T> 객체에는 List도 바로 대입 가능
            a3 = a2;

            // [4] IEnumerable 타입에서 ToList() 메서드로 List 형태로 변환
            List<string> a4 = a3.ToList();

            // [5] IEnumerable 타입은 foreach 구문 사용가능
            foreach (string s in a3)
            {
                Console.WriteLine(s);
            }

            // [6] 배열, 리스트 타입은 for 문으로 반복 가능
            for (int i = 0; i < a4.Count; i++)
            {
                Console.WriteLine(a4[i]);
            }
        }
    }
}
