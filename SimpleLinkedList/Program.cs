using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 56, 30, 70 };
            Console.WriteLine("Displaying elements of a Linked List: ");
            LinkedList<int> MyList = new LinkedList<int>(arr);
            foreach (int res in MyList)
            {
                Console.WriteLine(res);
            }
        }
    }
}
