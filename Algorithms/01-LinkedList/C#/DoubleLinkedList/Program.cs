using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            HelperDLL objHelper = new HelperDLL();
            DoubleLinkedList myLinkedList = new DoubleLinkedList();

            objHelper.InsertFront(myLinkedList, 10);
            objHelper.InsertFront(myLinkedList, 20);
            objHelper.InsertLast(myLinkedList, 100);
            objHelper.InsertBefore(myLinkedList.head.prev, 30);
            objHelper.InsertAfter(myLinkedList.head.next, 40);
            objHelper.PrintList(myLinkedList);
            Console.WriteLine();
            objHelper.ReverseLinkedList(myLinkedList);
            objHelper.PrintList(myLinkedList);
            Console.WriteLine();
        }
    }
}