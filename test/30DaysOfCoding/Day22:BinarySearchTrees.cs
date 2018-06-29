using System;
using System.Collections.Generic;

/*
 * Source: https://www.hackerrank.com/challenges/30-binary-search-trees/problem
*/

namespace test.DaysOfCoding
{
    class Node3
    {
        public Node3 left, right;
        public int data;
        public Node3(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    public class BinarySearchTrees
    {
        //solution 1
        private int getHeight(Node3 root)
        {
            bool looping = true;
            int count = 0;

            List<Node3> nodes = new List<Node3>();
            nodes.Add(root);

            while (looping)
            {
                List<Node3> nodesToAdd = new List<Node3>();

                foreach (Node3 n in nodes)
                {
                    if (n.left != null)
                        nodesToAdd.Add(n.left);

                    if (n.right != null)
                        nodesToAdd.Add(n.right);
                }

                nodes.Clear();

                foreach (Node3 n in nodesToAdd)
                    nodes.Add(n);


                count++;

                if (nodes.Count == 1 && nodes[0].left == null && nodes[0].right == null)
                    looping = false;
            }

            return count;
        }

        //solution 2
        private int getHeight_alt(Node3 root)
        {

            int leftcount = 1;
            int rightcount = 1;

            Node3 leftNode = root.left;
            Node3 rightNode = root.right;

            if (leftNode != null)
                leftcount += getHeight_alt(leftNode);

            if (rightNode != null)
                rightcount += getHeight_alt(rightNode);

            if (leftNode == null && rightNode == null)
                leftcount = rightcount = 0;

            return (leftcount > rightcount) ? leftcount : rightcount;
        }

        private Node3 insert(Node3 root, int data)
        {
            if (root == null)
            {
                return new Node3(data);
            }
            else
            {
                Node3 cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        public void Main()
        {
            Node3 root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);

            int height_alt = getHeight_alt(root);
            Console.WriteLine(height_alt);

        }
    }
}