using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("이안", "개발자");
            table.Add("가든", "기획자");
            
            Console.WriteLine(table.Count);
            Console.WriteLine(table.Contains("이안"));


            foreach(DictionaryEntry t in table)
            {
                Console.WriteLine($"Key : {t.Key}, Value : {t.Value}");
            }

            foreach(var t in table)
            {
                Console.WriteLine(t.ToString());
            }
               

        }

        private static void queueExercise()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            foreach(var q in queue)
            {
                Console.WriteLine(q);
            }

            queue.Dequeue();
            queue.Dequeue();

            foreach (var q in queue)
            {
                Console.WriteLine(q);
            }
        }

        private static void stackExercise()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
      

            foreach(var s in stack)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(stack.Peek());
        }

        /// <summary>
        /// 첫 번째 컬렉션 예제 ArrayList
        /// </summary>
        private static void arraylistExercise()
        {
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
            list.Add(6);
            arraylistExercise();
            // [1] using loop for 
            loop_for(list);

            // [2] using loop foreach
            loop_foreach(list);
        }

        static void loop_for(ArrayList list)
        {
            Console.WriteLine();
            for (int i=0; i<list.Count; i++)
            {
                Console.Write(list[i]);
            }
        }

        static void loop_foreach(ArrayList list)
        {
            Console.WriteLine();
            foreach (var l in list)
            {
                Console.Write(l);
            }
        }
       
    }
}
