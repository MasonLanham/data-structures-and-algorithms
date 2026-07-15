'''
Given a binary tree, invert it and return the new value. You may invert it in-place.

To "invert" a binary tree, switch the left subtree and the right subtree, and invert them both. Inverting an empty tree does nothing.
'''
class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

def invert_binary_tree(tree: Node) -> Node:
    if tree is not None:
        return Node(tree.val, invert_binary_tree(tree.right), invert_binary_tree(tree.left))
    else:
        return None
