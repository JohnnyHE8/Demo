using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree b = new Tree();
            b.Insert(5);
            b.Insert(7);
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
            //b.DisplayByOrder();
            Console.ReadKey();
        }
    }

    class Node
    {
        public int Data;
        public Node left;
        public Node right;
        public void Display()
        {
            Console.WriteLine();
        }
    }

    class Tree
    {
        private Node root;

        public void Insert(int n)
        {
            Node parent;
            Node newNode = new Node();
            newNode.Data = n;

            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                while (true)
                {
                    parent = current;
                    if (newNode.Data < current.Data)
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
            {
                Console.WriteLine(parent.Data);
            }
            else
            {
                child = child.left;
                while (child.right != null)
                    child = child.right;
                Console.WriteLine(child.Data);
            }
        }
    }

    
}
