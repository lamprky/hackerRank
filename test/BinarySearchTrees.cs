using System;
//using System.Collections.Generic;

//class Node
//{
//    public Node left, right;
//    public int data;
//    public Node(int data)
//    {
//        this.data = data;
//        left = right = null;
//    }
//}
class BinarySearchTrees {

    //solution 1
    //static int getHeight(Node root)
    //{
    //    bool looping = true;
    //    int count = 0;

    //    List<Node> nodes = new List<Node>();
    //    nodes.Add(root);

    //    while(looping)
    //    {
    //        List<Node> nodesToAdd = new List<Node>();

    //        foreach(Node n in nodes)
    //        {
    //            if (n.left != null)
    //                nodesToAdd.Add(n.left);

    //            if (n.right != null)
    //                nodesToAdd.Add(n.right);
    //          }

    //        nodes.Clear();

    //        foreach (Node n in nodesToAdd)
    //            nodes.Add(n);
            
                     
    //        count++;

    //        if (nodes.Count == 1 && nodes[0].left == null && nodes[0].right == null)
    //            looping = false;
    //    }
        

    //    return count;
    //}

    //solution 2
    //static int getHeight(Node root)
    //{
        
    //    int leftcount = 1;
    //    int rightcount = 1;

    //    Node leftNode = root.left;
    //    Node rightNode = root.right;
 
    //    if(leftNode != null)
    //        leftcount += getHeight(leftNode);

    //    if (rightNode != null)
    //        rightcount += getHeight(rightNode);
        
    //    if (leftNode == null && rightNode == null)
    //        leftcount = rightcount = 0;
        
    //    return (leftcount> rightcount)?leftcount:rightcount;
    //}

    //static Node insert(Node root, int data)
    //{
    //    if (root == null)
    //    {
    //        return new Node(data);
    //    }
    //    else
    //    {
    //        Node cur;
    //        if (data <= root.data)
    //        {
    //            cur = insert(root.left, data);
    //            root.left = cur;
    //        }
    //        else
    //        {
    //            cur = insert(root.right, data);
    //            root.right = cur;
    //        }
    //        return root;
    //    }
    //}

    //static void Main(String[] args)
    //{
    //    Node root = null;
    //    int T = Int32.Parse(Console.ReadLine());
    //    while (T-- > 0)
    //    {
    //        int data = Int32.Parse(Console.ReadLine());
    //        root = insert(root, data);
    //    }
    //    int height = getHeight(root);
    //    Console.WriteLine(height);

    //}
}