/*
Given the root node of a valid BST and a value to insert into the tree, return a new root node representing the valid BST with the addition of the new item. If the new item already exists in the binary search tree, do not insert anything.
You must expand on the original BST by adding a leaf node. Do not change the structure of the original BST.

Input
bst — a binary tree representing the existing BST.
val — an integer representing the value to be inserted.

Output
A valid BST with the inserted number, or the same BST if the number already exists.
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

    public static Node<int> InsertBst(Node<int> bst, int val)
    {
        if(bst is null){
            return new Node<int>(val, null, null);
        }
        else{
            if(val > bst.val){
                bst.right = InsertBst(bst.right, val);
            }
            else if(val < bst.val){
                bst.left = InsertBst(bst.left, val);
            }
            return bst;
        }
    }
}
