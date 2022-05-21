using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_yield
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //foreach(var item in iteratorEx.MultiData())
            //{
            //    Console.WriteLine(item);
            //}

            int[] numbers = { 1, 5, 3, 10, 11, 21 };
            foreach (var n in Iterator_IEnumerable.Generater1(numbers, 10))
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("---------------------");
            foreach(var n in Iterator_IEnumerable.Generater2(numbers, 5))
            {
                Console.WriteLine(n);
            }

            var nums = Example.GetNumbers().GetEnumerator();
            Console.WriteLine(nums.Current);
            nums.MoveNext();
            Console.WriteLine(nums.Current);
            nums.MoveNext();
            Console.WriteLine(nums.Current);
        }
    }

    public static class iteratorEx
    {
        public static IEnumerable MultiData()
        {
            yield return "Hello";
            yield return "Hello2";
            yield return "Hello3";
        }
    }

    public static class Iterator_IEnumerable
    {
        public static IEnumerable<int> Generater1(int[] numbers, int greater)
        {
            List<int> temp = new List<int>();

            
            foreach(var n in numbers)
            {
                if(n > greater)
                {
                    temp.Add(n);
                }
                
            }
            return temp;
        }

        public static IEnumerable Generater2(int[] numbers, int greater)
        {
            foreach(var n in numbers)
            {
                if(n > greater)
                {
                    yield return n;
                }
            }
        }
    }

    public class Example
    {
        public static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 3;
            yield return 5;

        }
    }
    
}
