using System;

namespace StackImplementation
{
    internal class Stack
    {
        static readonly int MAX = 10;
        int top;
        int[] stack = new int[MAX];

        bool isEmpty()
        {
            return (top < 0);
        }

        public Stack()
        {
            top = -1;
        }

        bool isFull()
        {
            return (top >= MAX);
        }
        internal bool Push(int data)
        {
            if(isFull())
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        internal int Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                return stack[top--];
            }
        }

        internal void Peek()
        {
            if(isEmpty())
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                Console.WriteLine("Topmost Element of the stack : " + stack[top]);
            }
        }

        internal void PrintStack()
        {
            if(isEmpty())
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine("Element : " + stack[i]);
                }
            }
        }
    }
}
