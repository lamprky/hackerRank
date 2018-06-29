using System;

/*
 * Source: https://www.hackerrank.com/challenges/30-exceptions-string-to-integer/problem
*/

namespace test.DaysOfCoding
{
    public class Node4
    {
        public int data;
        public Node4 next;

        public Node4(int d)
        {
            data = d;
            next = null;
        }

    }

    public class LinkedListNodes
    {
        private Node4 insert(Node4 head, int data)
        {
            Node4 node = new Node4(data);

            if (head == null)
                head = node;
            else
            {
                Node4 nextNode = head;
                while (nextNode.next != null)
                {
                    nextNode = nextNode.next;
                }
                nextNode.next = node;
            }
            return head;
        }

        private void display(Node4 head)
        {
            Node4 start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public void Main()
        {
            Node4 head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }
}