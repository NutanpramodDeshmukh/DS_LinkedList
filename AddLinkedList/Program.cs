using AddLinkedList.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AddLinkedList.Properties.LinkedList;

namespace AddLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
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
