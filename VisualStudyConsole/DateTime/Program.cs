using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExample
{

    // 구조체 날짜 관련 Built In 
    // 날짜 DateTime 구조체, TimeSpan 구조체 사용



    class DateTimeExample
    {
        static void Main(string[] args)
        {
            // [1]  현재 시간 출력 : DateTime 구조체 (System.DateTime)
            Console.WriteLine(DateTime.Now);

            // [2] 년, 월, 일, 시, 분, 초 출력
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Millisecond);

            // [3] DateTime 형식의 변수 선언
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToLongDateString());

            // [4] 시간차 구하기 : TimeSpan 구조체
            TimeSpan dday 


            // Console.WriteLine(new GetDataTimeFromHour().GetDateTimeFromYearlyHourNumber(25));
        }




    }


    // 1년 8760시간
    // 1 ~ 8760
    // 1 => 2018년 1월 1일 0시
    // 8760 => 2018년 12월 31일 23시

    // f(x) => 0000년 00월 00일 00시
    class GetDataTimeFromHour
    {
        public DateTime GetDateTimeFromYearlyHourNumber(int num)
        {
            return (new DateTime(2022, 1, 1, 0, 0, 0)).AddHours(--num);
        }
    }
}
