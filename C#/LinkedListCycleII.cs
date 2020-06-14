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
    public ListNode DetectCycleByHashSet(ListNode head)
    {
        HashSet<ListNode> set = new HashSet<ListNode>();
        ListNode node = head;
        while (node != null)
        {
            if (!set.Contains(node))
            {
                set.Add(node);
                node = node.next;
            }
            else
            {
                return node;
            }
        }
        return null;
    }
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return null;
        }
        ListNode slowPointer = head;
        ListNode fastPointer = head;
        bool isCycle = false;
        while (slowPointer != null && fastPointer != null && fastPointer.next != null)
        {
            slowPointer = slowPointer.next;
            fastPointer = fastPointer.next.next;
            if (fastPointer == slowPointer)
            {
                isCycle = true;
                break;
            }
        }
        if (isCycle == false)
        {
            return null;
        }
        else
        {
            slowPointer = head;
            while (slowPointer!=fastPointer)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next;
            }
            return slowPointer;
        }
    }

    public static void Main(String[] args)
    {

    }
}

