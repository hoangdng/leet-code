// C# program to print all distinct 
// elements of a given array  
using System;
using System.Collections.Generic;


class program
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        ListNode oddPointer = head;
        ListNode evenHead = head.next;
        ListNode evenPointer = evenHead;
        while (evenPointer != null && evenPointer.next != null)
        {
            oddPointer.next = evenPointer.next;
            oddPointer = oddPointer.next;
            evenPointer.next = oddPointer.next;
            evenPointer = evenPointer.next;
        }
        oddPointer.next = evenHead;
        return head;
    }

    public static void Main(String[] args)
    {
        Console.Write("dsadas");
    }
}

