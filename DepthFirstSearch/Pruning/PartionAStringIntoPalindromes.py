'''
Given a string s, find all ways to partition it so that every substring is a palindrome. Return all possible palindrome partitions of s.

Examples
Example 1:
Input: aab
Output:
  [
  ["a","a","b"],
  ["aa","b"]
  ]
'''
def dfs(start, cur_path, ans):
    #base case where we reached end with all palindromes
    if(start == len(s)):
        #append a copy of cur_path b/c mutable
        ans.append(cur_path[:])
        return

    #search remaining of string for palindrome, partition must be at least length 1
    for end in range(start + 1, len(s) + 1):
        #is palindrome vvv
        if s[start:end] == s[start:end][::-1]:
            #if palindrome then append it to cur_path and continue search
            cur_path.append(s[start:end])
            dfs(end, cur_path, ans)
            #pop cur_path that has been searched or pruned
            cur_path.pop()
        #implicitly prune by not continuing the search on invalid edges
    return
    
def partition(s: str) -> list[list[str]]:
    ans = []
    dfs(0, [], ans)
    return ans
