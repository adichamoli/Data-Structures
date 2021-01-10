using System;

namespace LinkedListQueue
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    class Queue
    {
        Node front, rear;

        public Queue()
        {
            this.front = this.rear = null;
        }

        public void Enqueue(int data)
        {
            Node node = new Node(data);

            if (this.rear == null)
            {
                this.rear = this.front = node;
                return;
            }

            this.rear.next = node;
            this.rear = node;
        }

        public void Dequeue()
        {
            if (this.front == null)
                return;

            Node node = this.front;
            this.front = this.front.next;

            if (this.front == null)
                this.rear = null;
        }

        public void Display()
        {
            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Node temp = this.front;

            while (temp != null)
            {
                Console.WriteLine("Element : " + temp.data);
                temp = temp.next;
            }
        }
    }
}
