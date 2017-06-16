using System;
using System.Collections;
using System.Collections.Generic;

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

        public static Node Partition(Node node, int x)
        {
            Node head = node;
            Node tail = node;

            while(node != null)
            {
                if(node.data <x)
                {
                    node.next = head;
                    node = head;
                }
                else
                {
                    tail.next = node;
                    tail = node;
                }
                node = node.next;
            }
            return head;
        }
        public static Node removeDuplicatesUnsorted(Node head)
        {
            Node Current = head;
            List<int> ll = new List<int>();
            Node Previous = new Node(0);
            while(Current.next != null)
            {
                if(ll.Contains(Current.data))
                {
                    Previous.next = Current.next;
                   
                }
                else
                {
                    ll.Add(Current.data);
                    Previous = Current;
                }
                Current = Current.next;
            }
            return head;
        }


        public static Node getKthtoLastElement(Node head, int k)
        {
            Node p1 = head;
            Node p2 = head;
            for(int i=0; i< k; i++)
            {
                p1 = p1.next;
            }

            while(p1!= null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }

            return p2;
        }

        public static Node removeDuplicates(Node head)
        {
            if (head != null)
            {
                Node start = head;
                while (start != null)
                {
                    if (start.next != null && start.data == start.next.data)
                    {
                        start.next = start.next.next;
                    }
                    else
                    {
                        start = start.next;
                    }
                }
            }
            return head;
        }


        public static Node insert(Node head, int data)
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
                Console.WriteLine(start.data + " ");
                Console.ReadLine();
                start = start.next;
            }
        }

       public static Node AddTwoLists(Node L1, Node L2)
        {
            Node sum = new Node(0);
            if(L1 == null && L2 != null)
            {
                return L2;
            }
            else if(L2 == null && L1 != null)
            {
                return L1;
            }
            else if(L1 == null && L2 == null)
            {
                return sum;
            }
            else if(L1 != null && L2 !=null)
            {
                int carry = 0;
                int total  = L1.data + L2.data + carry;
                carry = total / 10;
                sum.data = total % 10;
                L1 = L1.next;
                L2 = L2.next;
                sum = sum.next;

            }

            return sum;
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
            Node k = Partition(head, 3);
            display(k);           
        }

    }
}
