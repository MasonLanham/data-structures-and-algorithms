'''
In DFS, a state is information we pass from a parent call to a child call. In this problem, the state is the path from the root to the current node.

Once you can carry this path state correctly, you can solve many backtracking problems by the same pattern: choose, recurse, undo.

Ternary Tree Paths
Given a ternary tree (each node of the tree can have up to three children), find all the root-to-leaf paths.
'''
class Node:
    def __init__(self, val, children=None):
        if children is None:
            children = []
        self.val = val
        self.children = children
def is_leaf(root: Node):
    for child in root.children:
        if child is not None:
            return False
    return True

def dfs_helper(root: Node, path: str) -> list[str]:
    paths = []
    if is_leaf(root):
        return [path + str(root.val)]
    for child in root.children:
        paths += dfs_helper(child, path + str(root.val) + "->")
    return paths
    
def ternary_tree_paths(root: Node) -> list[str]:
    if root is None:
        return []
    else:
        result = dfs_helper(root, "")
    return result
