using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree b = new Tree();
            b.Insert(5);
            b.Insert(7);
            b.Insert(1);
            b.Insert(12);
            b.Insert(32);
            b.Insert(15);
            b.Insert(22);
            b.Insert(2);
            b.Insert(6);
            b.Insert(24);
            b.Insert(17);
            b.Insert(14);

            //b.FindMax();
            b.LesMax();
            Node a = b.FindKey(14);
            Node c = b.FindKey(1000);
            
            Console.WriteLine("Find: " + a.data);
            if (c != null)
            {
                Console.WriteLine(c.data);
            }
            else
            {
                Console.WriteLine("NUll");
            }

            b.FIND(2);

            Console.ReadKey();
        }
    }

    class Node
    {
        public int data;
        public Node left;
        public Node right;
        public void Display()
        {
            Console.WriteLine(data + " ");
        }
    }

    class Tree
    {
        private Node root;

        public void Insert(int number)
        {
            Node parent;
            Node newNode = new Node();
            newNode.data = number;

            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                while (true)
                {
                    parent = current;
                    if (newNode.data < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        public void LesMax()
        {
            Node parent = null;
            Node child = root;

            if (child == null)
                Console.WriteLine("BAD");
            else
            {
                while (child.right != null)
                {
                    parent = child;
                    child = child.right;
                }
            }

            if (child.left == null)
                Console.WriteLine(parent.data);
            else
            {
                child = child.left;
                while (child.right != null)
                    child = child.right;
                Console.WriteLine(child.data);
            }
        }

        public Node FindKey(int n)
        {
            Node current = root;

            while (current.data != n)
            {
                if (current.data > n)
                    current = current.left;
                else
                    current = current.right;

                if (current == null)
                    return null;
            }

            return current;
        }

        public void FIND(int k)
        {
            FindKthLargestNode(root, k);
        }

        private int index = 0;
        public void FindKthLargestNode(Node root, int k)
        {
            
            if (root == null)
                return;

            FindKthLargestNode(root.right, k);
            if (++index == k)
            {
                Console.WriteLine("The {0}th number is: {1}", k, root.data);
                return;
            }
            FindKthLargestNode(root.left, k);

        }
    }
}
