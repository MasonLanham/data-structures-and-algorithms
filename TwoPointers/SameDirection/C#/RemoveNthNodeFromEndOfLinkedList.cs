/*
Given the head of a linked list and an integer n, remove the n-th node from the end of the list and return the head of the modified list.

Input:

head: the head node of a singly linked list
n: an integer representing the position from the end (1-indexed)
Output:

Return the head of the modified linked list
Constraints:

The list has at least 1 node
n is a valid position from the end (1 <= n <= length of list)
Examples:

Example 1:

Input: head = [1, 2, 3, 4], n = 1
Output: [1, 2, 3]
Explanation: Remove the 1st node from the end (value 4)
Example 2:

Input: head = [1, 2, 3, 4], n = 2
Output: [1, 2, 4]
Explanation: Remove the 2nd node from the end (value 3)
Example 3:

Input: head = [1, 2, 3, 4], n = 4
Output: [2, 3, 4]
Explanation: Remove the 4th node from the end (the head, value 1)
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

    public static Node<int> RemoveNthFromEnd(Node<int> head, int n) {
        Node<int> slow = head;
        Node<int> fast = head;

        for(int i = 0; i < n; i++){
            fast = fast.next;
        }

        if(fast != null){
            while(fast.next != null){
                slow = slow.next;
                fast = fast.next;
            }
        }
        
        if(slow == head){
            return slow.next;
        }
        else{
            slow.next = slow.next.next;
        }
        return head;
    }
}
