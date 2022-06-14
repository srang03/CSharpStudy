using System;
using System.Linq;

namespace FunctionalProgrammingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionParameterWithAction((str => Console.WriteLine(str)), "Hello");
            Action<String> action = msg => Console.WriteLine(msg);
            FunctionParameterWithAction(action, "Hi");

            FunctionParameterWithFunc((x) => x * x, 2);

            int[] numbers = { 1, 3, 5, 100, 7, 9, 11, 20 };

            int max = numbers.Aggregate((f, s) => f > s ? f : s);
            Console.WriteLine(max);
        }
        static void FunctionParameterWithAction(Action<String> action, string message)
        {
            action.Invoke(message);
        }

        static void FunctionParameterWithFunc(Func<int, int> func, int number)
        {
            var res = func.Invoke(number);
            Console.WriteLine(res);
        }

        static Action<string> FunctionReturnValueWithAction()
        {
            return msg => Console.WriteLine(msg);
        }
            

    }
}
