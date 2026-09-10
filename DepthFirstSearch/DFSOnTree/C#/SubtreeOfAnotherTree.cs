/*Given two binary trees root and subRoot, determine if subRoot is a subtree of root. 
A subtree of a binary tree is a tree that consists of a node in the tree and all of its descendants. 
An empty tree is considered a subtree of any tree (including another empty tree).*/

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

    public static bool SubtreeOfAnotherTree(Node<int> root, Node<int> subRoot)
    {
        if(subRoot is null){
            return true;
        }
        else{
            return SubtreeCheck(root, subRoot);
        }
    }

    public static bool SubtreeCheck(Node<int> root, Node<int> subRoot){
        if(root is null && subRoot is null){
            return true;
        }
        else if(root is null){
            return false;
        }
        else if(subRoot is null){
            return false;
        }
        else{
            if(root.val == subRoot.val){
                return SubtreeCheck(root.left, subRoot.left) && SubtreeCheck(root.right, subRoot.right);
            }
            else{
                return SubtreeCheck(root.left, subRoot) || SubtreeCheck(root.right, subRoot);
            }
        }
    }
}
