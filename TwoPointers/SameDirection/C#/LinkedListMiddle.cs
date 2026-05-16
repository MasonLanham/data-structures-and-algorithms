/*
Find the middle node of a linked list.

Input: 0 1 2 3 4

Output: 2

If the number of nodes is even, then return the second middle node.

Input: 0 1 2 3 4 5

Output: 3
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public class Node<T>
    {
        public T val;
        public Node<T> next;

        public Node(T val)
        {
            this.val = val;
        }

        public Node(T val, Node<T> next)
        {
            this.val = val;
            this.next = next;
        }
    }
   public static int MiddleOfLinkedList(Node<int> head)
    {
        Node<int> slow = head;
        Node<int> fast = head.next;
        while(fast != null){
            slow = slow.next;
            fast = fast.next;
            if(fast != null){
                fast = fast.next;
            }
        }
        return slow.val;
    }
}
