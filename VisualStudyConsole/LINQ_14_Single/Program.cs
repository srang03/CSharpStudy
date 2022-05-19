using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// single() 메서드 : 특정한 컬렉션에서 조건에 맞는 데이터 하나 (단일 데이터)를 가져오는 메서드이다.
// single() 메서드를 실행했을 때 찾는 값이 없을 경우 에러를 발생하므로 try catch문으로 예외처리가 필요하다.

namespace LINQ_14_Single
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string> { "Red", "Blue", "Black", "White" };
            
            string red = colors.Single(x => x.ToLower() == "red");

            Console.WriteLine(red);

            try
            {
                // single 메서드는 없는 데이터를 요청할 경우 예외가 발생한다.
                string green = colors.Single(x => x.ToLower() == "green");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
