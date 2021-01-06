using System;
using System.Collections.Generic;
using System.Text;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.PrintStack();
            stack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", stack.Pop());
            stack.PrintStack();
        }
    }
}
