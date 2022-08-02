using System;

namespace _220802DelegateReivew
{
    public class Test2
    {
        public delegate int DelGetAge(int year);

        public void ShowMenu(DelGetAge GetAge, int menu)
        {
            int age = GetAge(1995);

            if( age >= 20)
            {
                Console.WriteLine($"age : {age}, You can buy it");
            }
            else
            {
                Console.WriteLine($"age : {age}, You can not buy it");
            }
        }


        public int GetAge_Korea(int year)
        {
            return DateTime.Now.Year - year + 1;
        }

        public int GetAge_Japan(int year)
        {
            return DateTime.Now.Year - year;
        }
    }
}
