using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    internal class Node
    {
        internal int data;
        internal Node next;
        internal Node prev;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }

    internal class DoubleLinkedList
    {
        internal Node head;
    }

    internal class HelperDLL
    {
        internal void InsertFront(DoubleLinkedList doubleLinkedList, int data)
        {
            Node node = new Node(data);
            node.next = doubleLinkedList.head;
            node.prev = null;

            if (doubleLinkedList.head != null)
                doubleLinkedList.head.prev = node;

            doubleLinkedList.head = node;
        }

        internal void InsertAfter(Node node, int data)
        {
            if(node == null)
            {
                Console.WriteLine("The given prevoius node cannot be null");
                return;
            }

            Node newNode = new Node(data);
            newNode.next = node.next;
            node.next = newNode;
            newNode.prev = node;

            if(newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }

        internal void InsertBefore(Node node, int data)
        {
            if (node == null)
            {
                Console.WriteLine("The given next node cannot be null");
                return;
            }

            Node newNode = new Node(data);
            newNode.prev = node.prev;
            node.prev = newNode;
            newNode.next = node;

            if (newNode.prev != null)
            {
                newNode.prev.next = newNode;
            }
        }

        internal void InsertLast(DoubleLinkedList doubleLinkedList, int data)
        {
            Node node = new Node(data);

            if(doubleLinkedList.head == null)
            {
                node.prev = null;
                doubleLinkedList.head = node;
                return;
            }

            Node lastNode = GetLastNode(doubleLinkedList);

            lastNode.prev = node;
            node.prev = lastNode;
        }

        internal Node GetLastNode(DoubleLinkedList doubleLinkedList)
        {
            Node node = doubleLinkedList.head;
            while (node.next != null)
                node = node.next;

            return node;
        }

        internal void DeleteNodeByKey(DoubleLinkedList doubleLinkedList, int data)
        {
            Node node = doubleLinkedList.head;

            if(node != null && node.data == data)
            {
                doubleLinkedList.head = node.next;
                doubleLinkedList.head.prev = null;
                return;
            }

            while (node != null && node.data != data)
                node = node.next;

            if (node == null)
                return;

            if (node.next != null)
                node.next.prev = node.prev;

            if (node.prev != null)
                node.prev.next = node.next;
        }

        internal void ReverseLinkedList(DoubleLinkedList doubleLinkedList)
        {
            Node node = null;
            Node current = doubleLinkedList.head;

            while(current != null)
            {
                node = current.prev;
                current.prev = current.next;
                current.next = node;
                current = current.prev;
            }

            if (node != null)
                doubleLinkedList.head = node.prev;
        }

        internal void PrintList(DoubleLinkedList doubleLinkedList)
        {
            Node node = doubleLinkedList.head;

            while(node != null)
            {
                Console.WriteLine("Element : " + node.data);
                node = node.next;
            }
        }
    }
}
