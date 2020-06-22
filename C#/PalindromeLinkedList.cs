// C# program to print all distinct 
// elements of a given array  
using System;
using System.Collections.Generic;
using System.Linq;

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
    public static bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return true;
        }
        ListNode currNode = head;
        List<int> listValue = new List<int>();
        while (currNode != null)
        {
            listValue.Add(currNode.val);
            currNode = currNode.next;
        }
        List<int> reverseListValue = new List<int>(listValue);
        reverseListValue.Reverse();
        if (listValue.ToArray().SequenceEqual(reverseListValue.ToArray()))
            return true;
        return false;
    }

    public static void Main(String[] args)
    {
        ListNode node1 = new ListNode(1);
        ListNode node2 = new ListNode(2);
        ListNode node3 = new ListNode(1);
        node1.next = node2;
        node2.next = node3;
        node3.next = null;
        Console.Write(IsPalindrome(node1));
    }
}

