using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;
        public int size = 0;

        public Node(int d)
        {
            this.data = d;
            size = 1;

        }

        public void insertNode(int d)
        {
            if(d<= data)
            {
                if(left == null)
                {
                    left = new Node(d);
                }
                else
                {
                    left.insertNode(d);
                }
            }
            else
            {
                if(right == null)
                {
                    right = new Node(d);
                }
                else
                {
                    right.insertNode(d);
                }
            }
            size++; 
        }

        public Node DeleteNode(Node root, int data)
        {
            if(root == null)
            {
                return root;
            }
           else if(data < root.data)
            {
                return DeleteNode(root.left, data);
            }
           else if(data > root.data)
            {
                return DeleteNode(root.right, data);
            }
            else if(root.left == null && root.right == null )
            {
                root = null;
                return root;
            }
            else if(root.right == null && root.left != null)
            {
                Node temp = new Node(0);
                temp = root;
                root = root.left;
                temp = null;
                return root;
            }
            else if(root.left == null && root.right != null)
            {
                Node temp = new Node(0);
                temp = root;
                root = root.right;
                temp = null;
                return root;

            }
            else if (root.left != null && root.right != null)
            {
                Node min = findmin(root.right);
                root.data = min.data;
                int minData = min.data;
                DeleteNode(root.right, minData);
            }

        }


        public  int Size()
        {
            return size;
        }

        public int Data()
        {
            return data;
        }

        public Node find(int d)
        {
            if(d==data)
            {
                return this;
            }
            else if(d<= data)
            {
                return left != null ? left.find(d) : null;
            }
            else if(d>= data)
            {
                return right != null ? right.find(d) : null;
            }
            return null;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[7] { 3, 20, 24, 56, 29, 45, 2 };
            Node n = new Node(a[0]);

            for(int i=1; i< a.Length; i++)
            {
                n.insertNode(a[i]);
                Console.WriteLine(n.Size());
                Console.ReadLine();
            }

            Console.WriteLine("n.left ==> Data:  " + n.left.data+ "Size: " + n.left.size);
            Console.WriteLine("n.right ==> Data:  " + n.right.data + "Size: " + n.right.size);
            Console.ReadLine();

        }
    }
}
