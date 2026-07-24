'''
Combinatorial Example Problem
Given a non-negative integer n, find all n-letter words composed by 'a' and 'b', 
return them in a list of strings in lexicographical order.

Input: 2
Output: ["aa", "ab", "ba", "bb"]
Input: 4
Output: ["aaaa", "aaab", "aaba", "aabb", "abaa", "abab", "abba", "abbb", "baaa", "baab", "baba", "babb", "bbaa", "bbab", "bbba", "bbbb"]
'''
def dfsPather(n: int, valChars: str, path: str) -> list[str]:
    if n == 0:
        return [path]
    paths = []
    for char in valChars:
        paths += dfsPather(n - 1, valChars, path + char)
    return paths

def letter_combination(n: int) -> list[str]:
    return dfsPather(n, 'ab', "")
