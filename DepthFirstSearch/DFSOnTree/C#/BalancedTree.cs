/*
A binary tree is considered balanced if, for every node in the tree, the difference in the height of its left and right subtrees is at most 1.

In other words, the height of the two subtrees for every node in the tree differs by no more than one.

The height of a subtree is the number of edges on the longest path from that subtree's root down to any leaf node. (This is distinct from depth, which measures the distance from the tree's root down to a specific node.)

Note: An empty tree is considered balanced by definition.

In that case, given a binary tree, determine if it is balanced.
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

    public static bool IsBalanced(Node<int> tree)
    {
        if(TreeHeight(tree) < 0){
            return false;
        }
        else{
            return true;
        }
    }

    public static int TreeHeight(Node<int> root){
        if(root is null){
            return 0;
        }
        int left = TreeHeight(root.left);
        int right = TreeHeight(root.right);
        if(Math.Abs(left - right) > 1){
            return -1;
        }
        else{
            return Math.Max(left, right) + 1;
        }
    }
}
