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
    while right < len(s):
        #Expand Window
        map[ord(s[right]) - ord('1')] += 1
        #Maintain Valid Window
        while map[ord(s[right]) - ord('1')] > 1:
            map[ord(s[left]) - ord('1')] -= 1
            left += 1
        #Update longest
        longest = max(longest, right - left + 1)
        right += 1
    return longest

