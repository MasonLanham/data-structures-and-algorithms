/*A binary search tree is a binary tree with the property that for any node, the value of this node is greater than any node in its left subtree and less than any node's value in its right subtree. In other words, an inorder traversal of a binary search tree yields a list of values that is monotonically increasing (strictly increasing).

Given a binary tree, determine whether it is a binary search tree.*/

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

    public static bool ValidBst(Node<int> root)
    {
        return IOTHelper(root, int.MinValue, int.MaxValue);
    }

    public static bool IOTHelper(Node<int> root, int mustBeGreaterThan, int mustBeLessThan){
        if(root is null){
            return true;
        }
        else if(root.val <= mustBeGreaterThan || root.val >= mustBeLessThan){
            return false;
        }
        else{
            bool left = IOTHelper(root.left, mustBeGreaterThan, root.val);
            bool right = IOTHelper(root.right, root.val, mustBeLessThan);
            return left && right;
        }
    }
}
