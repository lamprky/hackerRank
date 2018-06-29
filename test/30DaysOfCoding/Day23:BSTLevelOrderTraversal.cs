using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
 * Source:https://www.hackerrank.com/challenges/30-binary-trees/problem
*/

namespace test.DaysOfCoding
{
    class Node2
    {
        public Node2 left, right;
        public int data;
        public Node2(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    public class BSTLevelOrderTraversal
    {
        private void levelOrder(Node2 root)
        {
            bool looping = true;
            string res = "";
            List<Node2> nodes = new List<Node2>();
            nodes.Add(root);

            while (looping)
            {
                List<Node2> nodesToAdd = new List<Node2>();

                foreach (Node2 n in nodes)
                {
                    if (n.left != null)
                        nodesToAdd.Add(n.left);

                    if (n.right != null)
                        nodesToAdd.Add(n.right);
                }

                foreach (Node2 n in nodes)
                    res = res + n.data + " ";

                nodes.Clear();

                foreach (Node2 n in nodesToAdd)
                    nodes.Add(n);

                if (nodes.Where(x => x.left == null).Count() == nodes.Count()
                    && nodes.Where(x => x.right == null).Count() == nodes.Count())
                {
                    looping = false;
                    foreach (Node2 n in nodes)
                        res = res + n.data + " ";
                }
            }

            Console.WriteLine(res);

        }

        private Node2 insert(Node2 root, int data)
        {
            if (root == null)
            {
                return new Node2(data);
            }
            else
            {
                Node2 cur;
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
            Node2 root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);

        }
    }
}