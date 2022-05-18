using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_02_WHERE
{

    // Where : 컬렉션에서 조건에 만족하는 데이터들을 가져오는 기능
    // Where 반환값이 IEnumerable<T>이다. 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Angular"); names.Add("Bootstrap"); names.Add("C#");

            IEnumerable<string> e = names.Where(x => x.Contains("a"));
            // 컬렉션에서 문자열 "a"를 포함하는 것들의 IEnumberable<T> 타입으로 생성
            foreach (string s in e)
            {
                Console.WriteLine("찾은 결과 : " + s);
            }
        }
    }
}
