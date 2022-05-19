using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationForUserRegister
{
    // 만 14세 미만 체크 메서드 구현
    internal class Program
    {
        static void Main(string[] args)
        {
            // [!] 만 14세 미만 by (년, 월, 일)
            Console.WriteLine(IsBelow14(2008, 5, 16));
            Console.WriteLine(IsBelow14(2008, 5, 17));
            Console.WriteLine(IsBelow14(2008, 5, 18));

        }
        public static bool IsBelow14(int year, int month, int day)
        {
     
            var yearDiff = DateTime.Now.Year - year;
            var monthDiff = DateTime.Now.Month - month;
            var dayDiff = DateTime.Now.Day - day;

            if (yearDiff == 14)
            {
                if (monthDiff < 0 || dayDiff < 0)
                {
             
                    return true;
                }
            }
            else if (yearDiff < 14)
            {
                return true;

            }
             return false;
        
        }
    }
}
