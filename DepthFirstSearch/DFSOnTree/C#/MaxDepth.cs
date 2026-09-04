/*
Max depth of a binary tree is the longest root-to-leaf path. Given a binary tree, find its max depth. Here, we define the length of the path to be the number of edges on that path, not the number of nodes.
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

    public static int TreeMaxDepth(Node<int> root)
    {
        if(root is null){
            return 0;
        }
        else{
            int left = -1;
            int right = -1;
            if(root.left is not null){
                left = TreeMaxDepth(root.left);
            }
            if(root.right is not null){
                right = TreeMaxDepth(root.right);
            }
            return Math.Max(left, right) + 1;
        }
    }
}
