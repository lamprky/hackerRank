//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
////class Node
////{
////    public Node left, right;
////    public int data;
////    public Node(int data)
////    {
////        this.data = data;
////        left = right = null;
////    }
////}
//class BSTLevelOrderTraversal {
//    static void levelOrder(Node root)
//    {
//        bool looping = true;
//        string res = "";
//        List<Node> nodes = new List<Node>();
//        nodes.Add(root);

//        while(looping)
//        {
//            List<Node> nodesToAdd = new List<Node>();

//            foreach (Node n in nodes)
//            {
//                if (n.left != null)
//                    nodesToAdd.Add(n.left);

//                if (n.right != null)
//                    nodesToAdd.Add(n.right);
//            }

//            foreach (Node n in nodes)
//                res = res + n.data + " ";
            
//            nodes.Clear();

//            foreach (Node n in nodesToAdd)
//                nodes.Add(n);

//            if (nodes.Where(x=>x.left == null).Count() == nodes.Count() 
//                && nodes.Where(x => x.right == null).Count() == nodes.Count())
//            {
//                looping = false;
//                foreach (Node n in nodes)
//                    res = res + n.data + " ";
//            }
//        }

//        Console.WriteLine(res);

//    }

//    static Node insert(Node root, int data)
//    {
//        if (root == null)
//        {
//            return new Node(data);
//        }
//        else
//        {
//            Node cur;
//            if (data <= root.data)
//            {
//                cur = insert(root.left, data);
//                root.left = cur;
//            }
//            else
//            {
//                cur = insert(root.right, data);
//                root.right = cur;
//            }
//            return root;
//        }
//    }
//    //static void Main(String[] args)
//    //{
//    //    Node root = null;
//    //    int T = Int32.Parse(Console.ReadLine());
//    //    while (T-- > 0)
//    //    {
//    //        int data = Int32.Parse(Console.ReadLine());
//    //        root = insert(root, data);
//    //    }
//    //    levelOrder(root);

//    //}
//}