using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackUsingLinkedList
{
    class Program
    {

        public class Node
        {
            public int data { get; set; }
            public Node next { get; set; }
            public Node(int data)
            {
                this.data = data;
            }
        }
        private Node Top;
        public int pop()
        {
            if (Top == null) throw new NullReferenceException();
            int item = Top.data;
            Top = Top.next;
            return item;
        }
        public void push(int data)
        {
            Node T = new Node(data);
            T.next = Top;
            Top = T;
        }
        public int Peek()
        {
            return Top.data;
        }
        public bool IsEmpty()
        {
            return Top == null;
        }


        static void Main(string[] args)
        {
        }
    }
}
