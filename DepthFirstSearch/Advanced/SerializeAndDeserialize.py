'''
Given a binary tree, write a serialize function that converts the tree into a string and a deserialize function that converts a string back to a binary tree. 
You may serialize the tree into any string representation you want, as long as it can be deserialized properly.
'''

class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

def serialize(root):
    if(root is None):
        return "x"
    else:
        return " ".join([str(root.val), serialize(root.left), serialize(root.right)])

def deserialize(s, pos):
    if s[pos] == "x":
        return None, pos, pos + 1
    else:
        end = pos + 1
        while(s[end] != " "):
            end += 1
        current = Node(int(s[pos:end]), None, None)
        pos = end + 1
        current.left, pos, end = deserialize(s, pos)
        pos = end + 1
        current.right, pos, end = deserialize(s, pos)
        return current, pos, end
