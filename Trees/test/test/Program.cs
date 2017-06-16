using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Node
    {
        public int data;
        public Node left;
        public Node Right;

        public Node(int data)
        {
            this.data = data;
        }

        public void insertNode(int d)
        {
            if(d< data)
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
                if(Right == null)
                {
                    Right = new Node(d);
                }
                else
                {
                    Right.insertNode(d);
                }
            }
        }


        public Node DeleteNode(Node root, int data)
        {
            if (root == null)
            {
                return root;
            }
            else if(data < root.data)
            {
                DeleteNode(root.left, data);
            }
            else if(data > root.data)
            {
                DeleteNode(root.Right, data);
            }

            else if(root.left == null && root.Right == null)
            {
                root = null;
                return root;

            }
            else if(root.Right == null && root.left != null)
            {
                Node temp = new Node(0);
                temp = root;
                root = root.left;
                temp = null;
                return root;
            }

            else if(root.Right !=null && root.left == null)
            {
                Node temp = new Node(0);
                temp = root;
                root = root.Right;
                temp = null;
                return root;
            }
            else if(root.Right!= null && root.left != null)
                    {
                Node Nodemin = findmin(root.Right, data);
                int minData = Nodemin.data;
                root.data = Nodemin.data;
                DeleteNode(root.Right, minData);

            }
    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
