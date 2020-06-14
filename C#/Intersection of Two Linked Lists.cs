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
    public ListNode GetIntersectionNodeByHashSet(ListNode headA, ListNode headB)
    {
        HashSet<ListNode> set = new HashSet<ListNode>();
        while (headA != null)
        {
            set.Add(headA);
            headA = headA.next;
        }
        while (headB != null)
        {
            if (set.Contains(headB))
            {
                return headB;
            }
            headB = headB.next;
        }
        return null;
    }
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA != null && headB != null)
        {
            ListNode pointerA = headA;
            ListNode pointerB = headB;
            double loop = 0;
            while (loop <= 2)
            {
                if (pointerA == pointerB)
                {
                    return pointerA;
                }
                pointerA = pointerA.next;
                pointerB = pointerB.next;
                if (pointerA == null)
                {
                    pointerA = headB;
                    loop += 0.5;
                }
                if (pointerB == null)
                {
                    pointerB = headA;
                    loop += 0.5;
                }
            }
        }
        return null;
    }

    public static void Main(String[] args)
    {

    }
}

