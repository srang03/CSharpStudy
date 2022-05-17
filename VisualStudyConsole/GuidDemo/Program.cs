using System;

namespace GuidDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string unique = System.Guid.NewGuid().ToString("X");
            Console.Write($"유일한 값 : {unique}");
        }
    }
}