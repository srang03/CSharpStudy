using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Queue FIFO
            
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            
        }
    }
}
