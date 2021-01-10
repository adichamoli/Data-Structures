using System;
using System.Collections;

namespace QueueClass
{
    class QueueClass
    {
        static void Display(Queue queue)
        {
            foreach (Object obj in queue)
            {
                Console.WriteLine("Element : " + obj);
            }
        }

        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Display(queue);
            Console.WriteLine("The number of elements in the Queue : " + queue.Count);

            queue.Dequeue();

            Display(queue);

            Console.WriteLine("The number of elements in the Queue : " + queue.Count);
            Console.WriteLine("Does the Queue contain : " + queue.Contains(3));

        }
    }
}
