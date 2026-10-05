/*
Given the root node of a valid BST and a value to insert into the tree, return a new root node representing the valid BST with the addition of the new item. If the new item already exists in the binary search tree, do not insert anything.

You must expand on the original BST by adding a leaf node. Do not change the structure of the original BST.
*/
class Node {
    constructor(val, left = null, right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

function insertBst(bst, val) {
    if(bst === null){
        return new Node(val, null, null);
    }
    else{
        if(bst.val > val){
            bst.left = insertBst(bst.left, val);
        }
        else if(bst.val < val){
            bst.right = insertBst(bst.right, val);
        }
        return bst;
    }
}
