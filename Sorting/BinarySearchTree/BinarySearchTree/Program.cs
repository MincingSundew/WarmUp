using System;
using System.Linq;
class Node
{
    public Node left;
    public Node right;
    public int data;
     public Node(int Data)
    {
        this.data = Data;
        left = null;
        right = null;
    }
}
class Solution
{
   public  static int getHeight(Node root)
    {
        if (root == null || (root.left == null && root.right == null)) return 0;
         int height = 1+Math.Max(getHeight(root.left), getHeight(root.right));
        return height;
        

    }


    static Node insert(Node root, int data)
    {
        if(root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if(data <=root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
        }
        return root;
    }


    static void Main(String[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        int height = getHeight(root);
        Console.WriteLine(height);

    }
}

