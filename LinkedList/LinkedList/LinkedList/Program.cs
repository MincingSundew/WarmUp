using System;


namespace LinkedList
{ 
    class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    class Solution
    {
            public  static Node insert(Node head, int data)
        {
            Node temp = new Node(0);
            temp.next = null;           
             if(head == null)
            {
                head = temp;
                head.data = data;
            }
            else
            {
                Node Current = head;
                while(Current.next!= null)
                {
                    Current = Current.next;
                }
                Current.next = temp;
                Current.next.data = data;
            }
            return head;
        }


        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }

    }
}
