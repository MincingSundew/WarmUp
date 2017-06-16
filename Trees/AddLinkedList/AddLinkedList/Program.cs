using System;

public class Solution
{
     public class ListNode
    {
     public int val;
   public ListNode next;
     public ListNode(int x) { val = x; }
 }

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode sum = new ListNode(0);
        if (l1 == null && l2 != null)
        {
            return l2;
        }
        else if (l2 == null && l1 != null)
        {
            return l1;
        }
        else if (l1 == null && l2 == null)
        {
            return sum;
        }
        else if (l1 != null && l2 != null)
        {
            int carry = 0;
            int total = l1.val + l2.val + carry;
            carry = total / 10;
            sum.val = total % 10;
            l1 = l1.next;
            l2 = l2.next;
            sum = sum.next;

        }

        return sum;
    }

    public static void display(ListNode head)
    {
        ListNode start = head;
        while (start != null)
        {
            Console.WriteLine(start.val + " ");
            Console.ReadLine();
            start = start.next;
        }
    }


    static void Main(String[] args)
    {

        ListNode Temp = new ListNode(4);
        ListNode Temp2 = new ListNode(3);

        ListNode n1 = new ListNode(2);
        n1.next = Temp;
        n1.next.next = Temp2;

        ListNode Temp3 = new ListNode(6);
        ListNode Temp4 = new ListNode(4);

        ListNode n2 = new ListNode(5);
        n2.next = Temp3;
        n2.next.next = Temp4;

       ListNode n3 =  AddTwoNumbers(n1, n2);
        display(n3);
    }
}