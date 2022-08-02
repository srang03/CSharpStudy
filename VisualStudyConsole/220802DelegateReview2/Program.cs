using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220802DelegateReview2
{
    internal class Program
    {
        delegate int DelOperator(int a, int b);

        static void Main(string[] args)
        {
        }

        void TestCode()
        {

        }

        void Calc(int a, int b, Func<int, int, int> flag)
        {
            int res = 0;
            res = flag.Invoke(a, b);
            // res = flag(a, b);

        }

        int Add(int a, int b)
        {
            return a + b;
        }

        int Substract(int a, int b)
        {
            return a - b;
        }
    }
}
