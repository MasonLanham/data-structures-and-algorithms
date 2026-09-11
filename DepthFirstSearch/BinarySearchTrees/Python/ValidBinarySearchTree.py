'''A binary search tree is a binary tree with the property that for any node, the value of this node is greater than any node in its left subtree and less than any node's value in its right subtree. 
In other words, an inorder traversal of a binary search tree yields a list of values that is monotonically increasing (strictly increasing).

Given a binary tree, determine whether it is a binary search tree.'''

from math import inf
class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

def valid_bst(root: Node) -> bool:
    if root is not None:
        return dfs(root.left, -inf, root.val) and dfs(root.right, root.val, inf)
    else:
        return True

def dfs(root, minBarrier, maxBarrier):
    if root is None:
        return True
    #root.val must be greater than minBarrier and less than maxBarrier
    elif root.val <= minBarrier or root.val >= maxBarrier:
        return False
    else:
        return dfs(root.left, minBarrier, root.val) and dfs(root.right, root.val, maxBarrier)
      
