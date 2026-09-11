/* Given a binary tree, invert it and return the new value. You may invert it in-place.

To "invert" a binary tree, switch the left subtree and the right subtree, and invert them both. Inverting an empty tree does nothing. */

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

    public static Node<int> InvertBinaryTree(Node<int> tree)
    {
        if(tree is not null){
            return new Node<int>(tree.val, InvertBinaryTree(tree.right), InvertBinaryTree(tree.left));
        }
        else{
            return null;
        }
    }
}
