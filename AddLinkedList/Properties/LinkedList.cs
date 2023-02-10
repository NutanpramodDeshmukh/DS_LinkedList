using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddLinkedList.Properties
{
    internal class LinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node head;
            public Node(int data)
            {
                this.data = data;
            }
            public bool Add(int data)
            {
                Node n = new Node(data);
                if (head == null)
                {
                    head = n;
                    return true;
                }
                n.next = head;
                head = n;
                return true;
            }
        }
    }
}
