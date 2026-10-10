'''
Max depth of a binary tree is the longest root-to-leaf path. Given a binary tree, find its max depth. Here, we define the length of the path to be the number of edges on that path, not the number of nodes.
'''
class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

def dfsHelper(root: Node) -> int:
    if(root is None):
        return -1
    else:
        return max(dfsHelper(root.left), dfsHelper(root.right)) + 1

def tree_max_depth(root: Node) -> int:
    if(root is None):
        return 0
    else:
        return dfsHelper(root)
