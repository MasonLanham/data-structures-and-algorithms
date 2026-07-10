'''
Balanced Binary Tree
Prereq: Depth-First Search (DFS) Algorithm Explained

A binary tree is considered balanced if, for every node in the tree, the difference in the height of its left and right subtrees is at most 1.

In other words, the height of the two subtrees for every node in the tree differs by no more than one.

The height of a subtree is the number of edges on the longest path from that subtree's root down to any leaf node. (This is distinct from depth, which measures the distance from the tree's root down to a specific node.)

Note: An empty tree is considered balanced by definition.

In that case, given a binary tree, determine if it is balanced.

Parameter
tree: A binary tree.
Result
A boolean representing whether the tree given is balanced.
'''

class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
def postOrderTraversalHelper(tree: Node) -> int:
    if tree is not None:
        #Need to check left and right subtrees to see if balanced
        #Then Pass up tree height
        leftHeight = postOrderTraversalHelper(tree.left)
        rightHeight = postOrderTraversalHelper(tree.right)
        maxHeight = max(leftHeight, rightHeight)
        minHeight = min(leftHeight, rightHeight)
        #Unbalanced propagate up tree check this first as no other checks needed if true
        if minHeight < 0 or maxHeight - minHeight > 1:
            return -1
        #Current tree balanced propagate up tree the height
        else:
            return maxHeight + 1
    else:
        return 0
def is_balanced(tree: Node) -> bool:
    #Unbalanced if -1 is returned from postOrderTraversalHelper
    if(postOrderTraversalHelper(tree) != -1):
        return True
    else:
        return False
