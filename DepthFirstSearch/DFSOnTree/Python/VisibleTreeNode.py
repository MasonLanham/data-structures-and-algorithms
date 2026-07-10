"""In a binary tree, a node is labeled as "visible" if, on the path from the root to that node, there isn't any node with a value higher than this node's value.

The root is always "visible" since there are no other nodes between the root and itself. Given a binary tree, count the number of "visible" nodes."""

class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

def dfsHelper(root: Node, barrier: int) -> int:
    if root is not None:
        if root.val >= barrier:
            return 1 + dfsHelper(root.left, root.val) + dfsHelper(root.right, root.val)
        else:
            return 0 + dfsHelper(root.left, barrier) + dfsHelper(root.right, barrier)
    else:
        return 0

def visible_tree_node(root: Node) -> int:
    #Visible nodes are nodes that don't have a node between themselves and a root
    #that is greater than them.
    #We can return the number of visible nodes up the tree.
    #We need to maintain a state of what the greatest value is between the root
    #and the current node.
    if root is not None:
        return dfsHelper(root, root.val)
    else:
        return 0
