using System;
using System.Collections.Generic;

/*
 * Source: https://www.hackerrank.com/challenges/30-linked-list-deletion/problem
*/

namespace test.DaysOfCoding
{
    class Node1
    {
        public int data;
        public Node1 next;
        public Node1(int d)
        {
            data = d;
            next = null;
        }
    }

    public class MoreLinkedLists
    {

        private Node1 removeDuplicates(Node1 head)
        {
            LinkedList<int> list = new LinkedList<int>();

            if (head != null)
            {
                list.AddLast(head.data);

                Node1 node = head.next;
                while (node != null)
                {
                    if (!list.Contains(node.data))
                        list.AddLast(node.data);
                    node = node.next;
                }
                head = null;
                foreach (int n in list)
                {
                    head = insert(head, n);
                }
            }

            return head;
        }

        private Node1 insert(Node1 head, int data)
        {
            Node1 p = new Node1(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node1 start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;
            }
            return head;
        }

        private void display(Node1 head)
        {
            Node1 start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public void Main()
        {
            Node1 head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}
