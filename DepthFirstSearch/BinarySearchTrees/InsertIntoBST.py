'''Given the root node of a valid BST and a value to insert into the tree, return a new root node representing the valid BST with the addition of the new item. 
If the new item already exists in the binary search tree, do not insert anything.

You must expand on the original BST by adding a leaf node. Do not change the structure of the original BST.'''

class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

def insert_bst(bst: Node, val: int) -> Node:
    if bst is None:
        return Node(val, None, None)
    else:
        if val < bst.val:
            bst.left = insert_bst(bst.left, val)
        elif val > bst.val:
            bst.right = insert_bst(bst.right, val)
        return bst
