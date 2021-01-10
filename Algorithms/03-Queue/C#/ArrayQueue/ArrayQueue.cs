using System;

namespace ArrayQueue
{
    class LinearQueue
    {
        private int []queue;
        private int front;
        private int rear;
        private int max;

        public LinearQueue(int size)
        {
            queue = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void insert(int data)
        {
            if(rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                queue[++rear] = data;
            }
        }

        public int delete()
        {
            if(front == rear - 1)
            {
                Console.WriteLine("Queue Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Element Deleted : " + queue[front]);
                return queue[++front];
            }
        }

        public void display()
        {
            if (front == rear - 1)
            {
                Console.WriteLine("Queue Underflow");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                    Console.WriteLine("Element : " + queue[i]);
            }
        }
    }
}
