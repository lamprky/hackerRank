//using System;
//class Node
//{
//    public int data;
//    public Node next;

//    public Node(int d)
//    {
//        data = d;
//        next = null;
//    }

//}
//class LinkedListNodes {
//    public static Node insert(Node head, int data)
//    {        
//        Node node = new Node(data);

//        if (head == null)
//            head = node;
//        else
//        {
//            Node nextNode = head;
//            while(nextNode.next != null)
//            {
//                nextNode = nextNode.next;
//            }
//            nextNode.next = node;
//        }
//        return head;
//    }

//    public static void display(Node head)
//    {
//        Node start = head;
//        while (start != null)
//        {
//            Console.Write(start.data + " ");
//            start = start.next;
//        }
//    }

//    //static void Main(String[] args)
//    //{

//    //    Node head = null;
//    //    int T = Int32.Parse(Console.ReadLine());
//    //    while (T-- > 0)
//    //    {
//    //        int data = Int32.Parse(Console.ReadLine());
//    //        head = insert(head, data);
//    //    }
//    //    display(head);
//    //}
//}
