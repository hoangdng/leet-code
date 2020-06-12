// C# program to print all distinct 
// elements of a given array  
using System;
using System.Collections.Generic;

class GFG
{
    public class Node
    {
        public Node(int val)
        {
            _val = val;
        }
        public int _val { get; set; }
        public Node _next { get; set; }
    };
    public class MyLinkedList
    {

        /** Initialize your data structure here. */
        Node _head;
        public MyLinkedList()
        {
            _head = null;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            Node currentNode = _head;
            int count = 0;
            while (currentNode != null)
            {
                if (count == index)
                {
                    return currentNode._val;
                }
                count++;
                currentNode = currentNode._next;
            }
            return -1;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Node newNode = new Node(val);
            newNode._next = _head;
            _head = newNode;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            Node newNode = new Node(val);
            Node currentNode = _head;
            while (currentNode._next != null)
            {
                currentNode = currentNode._next;
            }
            currentNode._next = newNode;
        }

        /** Add a node of value val before the index-th node in the linked list. 
        If index equals to the length of linked list, the node will be appended to the end of linked list. 
        If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
            }
            else
            {
                var currentNode = _head;
                int count = 0;
                while (currentNode != null)
                {
                    if (count == index - 1)
                    {
                        var newNode = new Node(val);
                        newNode._next = currentNode._next;
                        currentNode._next = newNode;
                    }
                    currentNode = currentNode._next;
                    count++;
                }
                if (count == index)
                {
                    AddAtTail(val);
                }
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index == 0)
            {
                _head = _head._next;
            }
            else
            {
                Node currentNode = _head;
                Node previousNode = null;
                int count = 0;
                while (currentNode != null)
                {
                    if (count == index)
                    {
                        previousNode._next = currentNode._next;
                    }
                    count++;
                    previousNode = currentNode;
                    currentNode = currentNode._next;
                }
            }
        }

        public void printList()
        {
            Node currentNode = _head;
            while (currentNode != null)
            {
                Console.Write(currentNode._val + " ");
                currentNode = currentNode._next;
            }
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */


    // Driver Code 
    public static void Main(String[] args)
    {//  61204
        MyLinkedList list = new MyLinkedList();
        list.AddAtHead(7);
        list.AddAtHead(2);
        list.AddAtHead(1);
        list.AddAtIndex(3, 0);
        list.DeleteAtIndex(2);
        list.AddAtHead(6);
        list.AddAtTail(4);
        list.Get(4);
        list.AddAtHead(4);
        list.AddAtIndex(5, 0);
        list.AddAtHead(6);
        list.printList();
    }
}