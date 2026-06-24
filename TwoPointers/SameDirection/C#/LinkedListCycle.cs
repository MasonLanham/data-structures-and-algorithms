/*
Given a linked list with potentially a loop, determine whether the linked list from the first node contains a cycle in it. For bonus points, do this with constant space.

Parameters
nodes: The first node of a linked list with potentially a loop.

Result
Whether there is a loop contained in the linked list.

Constraints
1 <= len(nodes) <= 10^5
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

    public static bool HasCycle(Node<int> nodes)
    {
        Node<int> fast = nodes;
        Node<int> slow = nodes;
        while(fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
            if(Object.ReferenceEquals(slow, fast)){
                return true;
            }
        }
        return false;
    }
}
