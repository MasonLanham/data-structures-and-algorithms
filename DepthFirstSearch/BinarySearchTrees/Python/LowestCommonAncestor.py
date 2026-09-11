'''
Given a binary search tree (BST), find the lowest common ancestor (LCA) node of two given nodes in the BST.

According to the definition of LCA on Wikipedia: "The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”
'''
class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

def lca_on_bst(bst: Node, p: int, q: int) -> int:
    if bst is None:
        return None
    if bst.val < p and bst.val < q:
        return lca_on_bst(bst.right, p, q)
    elif bst.val > p and bst.val > q:
        return lca_on_bst(bst.left, p, q)
    else:
        return bst.val
    
