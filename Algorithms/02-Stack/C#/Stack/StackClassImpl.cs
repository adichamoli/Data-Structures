using System;

namespace Stack
{
    class StackClassImpl
    {
        public static void Main()
        {
            System.Collections.Stack myStack = new System.Collections.Stack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);
            myStack.Push(60);

            Console.WriteLine("Total number of elements in the Stack are : ");

            Console.WriteLine(myStack.Count);

            Console.WriteLine("Element at the top is : " + myStack.Peek());

            foreach (var item in myStack)
                Console.WriteLine("Element : " + item);

            myStack.Pop();

            Console.WriteLine("Element at the top is : " + myStack.Peek());

            Console.WriteLine("Checking Element 100 in Stack : " + myStack.Contains(100));

            Console.WriteLine("Remove All Elements");
            myStack.Clear();
        }
    }
}
