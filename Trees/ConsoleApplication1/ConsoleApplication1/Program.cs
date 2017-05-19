using System;

class Node
{
    public Node Left;
    public Node Right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        this.Left = null;
        this.Right = null;
    }
}
 class BST
{
    public Node createMinBST(int[] Values)
    {
        return createMinBST(Values, 0, Values.Length - 1);
    }
    public Node createMinBST(int[] Values, int start, int end)
    {
        if(end < start) { return null; }
        int Mid = (start + end) / 2;
        Node n = new Node(Values[Mid]);      
        n.Left = createMinBST(Values, start, Mid - 1);
        n.Right = createMinBST(Values, Mid + 1, end);
        return n;
    }


   


    public void Inorder(Node root)
    {
        if(root != null)
        {
            Inorder(root.Left);
            Console.WriteLine(root.data);
            Console.ReadLine();
            Inorder(root.Right);
        }
`e     }

    public void PreOrder(Node root)
    {
        if(root !=null)
        {
            PreOrder(root.Left);
            PreOrder(root.Right);
            Console.WriteLine(root.data);
            Console.ReadLine();
        }
    }

    public void PostOrder(Node root)
    {
        if(root!=null)
   666666666666666666666tyrf     {
            Console.WriteLine(root.data);
            Console.ReadLine();
            PostOrder(root.Left);
            PostOrder(root.Right);
        }
    }
}

class Program
{
     static void Main(String[] args)
    {
        
        BST bst = new BST();
        int[] val =  new int[7] { 1, 2, 3, 4, 5, 6 ,7};
       Node n=  bst.createMinBST(val);
        bst.Inorder(n);
        bst.PostOrder(n);
        bst.PreOrder(n);
    }
}