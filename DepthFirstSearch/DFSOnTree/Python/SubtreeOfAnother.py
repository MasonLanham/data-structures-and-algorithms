'''Given two binary trees root and subRoot, determine if subRoot is a subtree of root. 
A subtree of a binary tree is a tree that consists of a node in the tree and all of its descendants. 
An empty tree is considered a subtree of any tree (including another empty tree).'''

class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

def subtree_check(root: Node, subroot:Node) -> bool:
    if(root is None and subroot is None):
        return True
    elif(root is None and subroot is not None):
        return False
    elif(root is not None and subroot is None):
        return False
    elif(root.val != subroot.val):
        return False
    else:
        return subtree_check(root.left, subroot.left) and subtree_check(root.right, subroot.right)
def subtree_of_another_tree(root: Node, sub_root: Node) -> bool:
    subCheck = False
    if (root is None and sub_root is None) or sub_root is None:
        return True
    elif root is None:
        return False
    elif root.val == sub_root.val:
        subCheck = subtree_check(root, sub_root)
    if subCheck:
        return True
    else:
        leftCheck = subtree_of_another_tree(root.left, sub_root)
        rightCheck = subtree_of_another_tree(root.right, sub_root)
        return leftCheck or rightCheck
