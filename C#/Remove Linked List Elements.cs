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
    public ListNode RemoveElements(ListNode head, int val)
    {
        //Firstly, remove the head if head.val = val
        while (head != null && head.val == val)
        {
            head = head.next;
        }
        if (head == null)
        {
            return null;
        }
        //Then, remove any nodes after head if it equals val
        ListNode currNode = head.next;
        ListNode preNode = head;
        while (currNode != null)
        {
            if (currNode.val == val)
            {
                preNode.next = currNode.next;
                currNode = preNode.next;
            }
            else
            {
                preNode = currNode;
                currNode = currNode.next;
            }
        }
        return head;
    }

    public static void Main(String[] args)
    {
        Console.Write("dsadas");
    }
}

