using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion
{
    internal class Program
    {
        private Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }
        public bool Insert(int ind, int data)
        {
            Node n = new Node(data);
            if (ind == 0)
            {
                n.next = head;
                head = n;
                return true;
            }
            Node t = head, pre = null;
            while (ind > 0 && t != null)
            {
                ind--;
                pre = t;
                t = t.next;
            }
            if (ind == 0)
            {
                pre.next = n;
                n.next = t;
                return true;
            }
            throw new NullReferenceException("index is not in range");
        }
        public static void Main()
        {
            LinkedList<int> L = new LinkedList<int>();
            L.AddFirst(70);
            L.AddFirst(30);
            L.AddFirst(56);

            Console.Write("Linked List elements are: ");
            foreach (int i in L)
            {
                Console.Write(i + " ");
            }
        }
    }
}
