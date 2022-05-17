using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // 거의 사용하지 않고 Coolections.Generic으로 대체 되었다.

namespace CollectionDemo
{
    internal class Stack
    {
        static void Main(string[] args)
        {
            // Stack (LIFO)
            System.Collections.Stack stack = new System.Collections.Stack();
            stack.Push(100); // 데이터 삽입
            stack.Push(200);

            Console.WriteLine(stack.Peek());
        }
    }
}
