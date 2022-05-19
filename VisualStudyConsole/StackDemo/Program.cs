using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            // 박스에다가 포장하고, 사용할 때 포장을 풀어야 하는 추가적인 작업 필요

            Stack<int> stack_ = new Stack<int>();
            stack_.Push(10);
            stack_.Push(20);
            // 박싱과 언박싱 작업 불필요 
            // 편리성! 속도! 성능!

        }
    }
}
