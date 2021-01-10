using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListQueue
{
    class Program
    {
        public static void Main(String[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Display();
            
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Display();
            
            queue.Dequeue();
            queue.Display();
        }
    }
}
