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
    public bool HasCycle(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return false;
        }
        ListNode slowPointer = head;// 1 
        ListNode fastPointer = head.next;// 2
        int maxStepsJump = 2;
        while (slowPointer != null)
        {
            int step = 0;
            while (fastPointer != null)
            {
                if (fastPointer == slowPointer)
                {
                    return true;
                }
                fastPointer = fastPointer.next;
                step++;
                if (step == maxStepsJump)
                {
                    break;
                }
            }
            slowPointer = slowPointer.next;
        }
        return false;
    }

    public static void Main(String[] args)
    {

    }
}

