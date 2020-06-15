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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head.next == null && n == 1)
        {
            return null;
        }
        ListNode lastNode = head;
        while (n > 1)
        {
            lastNode = lastNode.next;
            n--;
        }
        ListNode nodeToDelete = head;
        ListNode preNodeToDelete = null;
        while (lastNode.next != null)
        {
            preNodeToDelete = nodeToDelete;
            nodeToDelete = nodeToDelete.next;
            lastNode = lastNode.next;
        }
        if (nodeToDelete == head)
        {
            head = nodeToDelete.next;
        }
        else if (nodeToDelete.next == null)
        {
            preNodeToDelete.next = null;
        }
        else
        {
            preNodeToDelete.next = nodeToDelete.next;
        }
        return head;
    }

    public static void Main(String[] args)
    {

    }
}

