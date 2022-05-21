using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [1] Action<T> : 매개변수는 있고 반환값이 없는 메서드를 대신 호출한다.
// [2] Func<T> : 매개변수와 반환값이 있는 메서드를 대신 호출한다.
// [3] Predicate<T> : T 매개변수에 대한 bool 값을 반환하는 메서드를 대신 호출한다.
namespace FuncDemo
{
    class Program
    {
        static void Show(string s1, string s2)
        {
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
        static void Main(string[] args)
        {
            // [1] Action
            Action<string> action = Console.WriteLine;
            action("Hello");

            Action<string, string> action2 = Show;
            action2("Hi", "guys");

            // [2] Func
            Func<string> func = ()=> { return "A"; };
            Func<int, string> func2 = (int x) => { return x.ToString(); };
            Func<int, bool> func3 = (int x) => { return x == 0 ? true : false; };

            // [3] Predicate
            // T 매개변수로 받아 어떤 로직을 수행 후 그 결과를 bool 값으로 반환
            Predicate<int> predicate = (int x) => x % 2 == 0;

            var list = Enumerable.Range(1, 101).ToList<int>();
            var a = FindNumber(list, (int x) => { return x % 33 == 0; });
            foreach(var item in a)
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<int> FindNumber(List<int> list, Predicate<int> predicate)
        {
            for (int i=0; i< list.Count; i++)
            {
                if (predicate(list[i]))
                {
                    yield return list[i];
                }
            }
        }
    }
}
