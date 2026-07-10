class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

def dfsHelper(root: Node) -> int:
    #individual node does not add to the height. This accommodates for that.
    leftHeight = 0
    rightHeight = 0
    if(root.right is None and root.left is None):
        return 0
    else:
        if(root.left is not None):
            leftHeight = 1 + dfsHelper(root.left)
        if(root.right is not None):
            rightHeight = 1 + dfsHelper(root.right)
    return max(leftHeight, rightHeight)

def tree_max_depth(root: Node) -> int:
    #Need to handle special case of null root
    if root is not None:
        return dfsHelper(root)
    else:
        return 0
