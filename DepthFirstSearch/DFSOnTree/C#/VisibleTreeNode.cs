/*
In a binary tree, a node is labeled as "visible" if, on the path from the root to that node, there isn't any node with a value higher than this node's value.

The root is always "visible" since there are no other nodes between the root and itself. Given a binary tree, count the number of "visible" nodes.

For example: Node 4 is not visible since 5>4, similarly Node 3 is not visible since both 5>3 and 4>3. Node 8 is visible since all 5<=8, 4<=8, and 8<=8.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public class Node<T>
    {
        public T val;
        public Node<T> left;
        public Node<T> right;

        public Node(T val)
        {
            this.val = val;
        }

        public Node(T val, Node<T> left, Node<T> right)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static int VisibleTreeNode(Node<int> root)
    {
        if(root is not null){
            return StatefulVisibleNode(root, int.MinValue);
        }
        return 0;
    }

    public static int StatefulVisibleNode(Node<int> root, int barrier){
        int isVisible = 0, left = 0, right = 0;
        int newBarrier = Math.Max(barrier, root.val);
        if(root.val >= barrier){
            isVisible = 1;
        }
        if(root.left is not null){
            left = StatefulVisibleNode(root.left, newBarrier);
        }
        if(root.right is not null){
            right = StatefulVisibleNode(root.right, newBarrier);
        }
        return  left + right + isVisible;
    }
}
