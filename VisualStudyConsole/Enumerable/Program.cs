using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Enumerable.Range(1, 10); // 1부터 10까지 요소를 가진 배열을 생성
            Enumerable.Repeat(1, 10); // 데이터 1인 10개의 요소를 가진 배열 생성
                

            // Enumerable은 예제와 테스트를 위해 사용하는 클래스
            list.AddRange(Enumerable.Range(1, 10));
            list.AddRange(Enumerable.Repeat(1, 10));
        }
    }
}
