using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1] Stack
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);

            Console.WriteLine("[1] Stack");
            Console.WriteLine(st.Count);
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Count);

            Console.WriteLine("[2] Queue");
            // [2] Queue
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);

            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Count);
        }
    }
    internal class Queue
    {
        List<object> list = new List<object> ();

        //Enqueue
        public void Enqueue(object obj)
        {
            list.Add (obj);
        }
        //Dequeue

        public object Dequeue()
        {
            object result = Peek();    
            list.RemoveAt(0);
            return result;
        }

        public object Peek()
        {
            return list[0];
        }

        public int Count
        {
            get { return list.Count; }
        }
    }

    internal class Stack
    {
        List<object> list = new List<object>();

        public void Push(object obj)
        {
            list.Add(obj);
        }

        public object Pop()
        {
            object result = Peek();
            list.RemoveAt(list.Count - 1);
            return result;
        }

        public object Peek()
        {
            return list[list.Count - 1];
        }

        public  int Count
        {
            get { return list.Count; }
        }
    }

}
