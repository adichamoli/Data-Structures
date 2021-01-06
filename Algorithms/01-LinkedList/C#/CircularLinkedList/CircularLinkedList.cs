using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularLinkedList
{
    class CircularList
    {
        private int data;
        private CircularList next;

        public CircularList()
        {
            data = 0;
            next = this;
        }

        public CircularList(int value)
        {
            data = value;
            next = this;
        }

        public CircularList Insdata(int value)
        {
            CircularList circularList = new CircularList(value);
            
            if(this.next == this)
            {
                circularList.next = this;
                this.next = circularList;
            }
            else
            {
                CircularList temp = this.next;
                circularList.next = temp;
                this.next = circularList;
            }

            return circularList;
        }

        public int Deldata()
        {
            if(this.next == this)
            {
                System.Console.WriteLine("\nOnly one node...");
                return 0;
            }

            CircularList circularList = this.next;
            this.next = this.next.next;
            circularList = null;
            return 1;
        }

        public void Traverse()
        {
            Traverse(this);
        }

        public void Traverse(CircularList circularList)
        {
            if (circularList == null)
                circularList = this;

            Console.WriteLine("Forward Direction");
            CircularList snode = circularList;

            do
            {
                Console.WriteLine(circularList.data);
                circularList = circularList.next;
            } while (circularList != snode);
        }

        public int Gnodes()
        {
            return Gnodes(this);
        }

        public int Gnodes(CircularList circularList)
        {
            if (circularList == null)
                circularList = this;

            int count = 0;
            CircularList snode = circularList;

            do
            {
                count++;
                circularList = circularList.next;
            } while (circularList != snode);
            
            Console.WriteLine("\nCurrent Node Value : " + circularList.data.ToString());
            Console.WriteLine("\nTotal nodes :" + count.ToString());
            
            return count;
        }

        static void Main(string[] args)
        {
            CircularList node1 = new CircularList(100);
            node1.Deldata();
            CircularList node2 = node1.Insdata(200);
            node1.Deldata();
            node2 = node1.Insdata(200);
            CircularList node3 = node2.Insdata(300);
            CircularList node4 = node3.Insdata(400);
            CircularList node5 = node4.Insdata(500);
            node1.Gnodes();
            node3.Gnodes();
            node5.Gnodes();
            node1.Traverse();
            node5.Deldata();
            node2.Traverse();
            node1.Gnodes();
            node2.Gnodes();
            node5.Gnodes();
            Console.Read();
        }
    }
}
