'''
Find the length of the longest substring of a given string without repeating characters.

Input: abccabcabcc

Output: 3

Explanation: The longest substrings are abc and cab, both of length 3.

Use the "Sample 1: abccabcabcc" preset in the visualizer below to replay this case.

Input: aaaabaaa

Output: 2

Explanation: ab is the longest substring, with a length of 2.

Use the "Sample 2: aaaabaaa" preset in the visualizer below to replay this case.
'''
def longest_substring_without_repeating_characters(s: str) -> int:
    map = [0] * 75
    left = 0
    right = 0
    longest = 0
    while(right < len(s)):
        #expand window while valid
        while(right < len(s) and map[ord(s[right]) - ord('1')] < 1):
            map[ord(s[right]) - ord('1')] += 1
            right += 1
            
        longest = max(longest, right - left)

        #break if right is outside bounds
        if right >= len(s):
            break
            
        #shrink window until valid
        while(left <= right and map[ord(s[right]) - ord('1')] > 0):
            map[ord(s[left]) - ord('1')] -= 1
            left += 1
            
            
    return longest
if __name__ == "__main__":
    s = input()
    res = longest_substring_without_repeating_characters(s)
    print(res)
