using System;

namespace ArrayQueue
{
    class Program
    {
        static void Main()
        {
            LinearQueue queue= new LinearQueue(5);

            queue.insert(10);
            queue.insert(20);
            queue.insert(30);
            queue.insert(40);
            queue.insert(50);

            Console.WriteLine("Items are : ");
            queue.display();

            queue.delete();
            queue.delete();

            Console.WriteLine("Items are : ");
            queue.display();
        }
    }
}
