/*
Find the length of the longest substring of a given string without repeating characters.

Input: abccabcabcc

Output: 3

Explanation: The longest substrings are abc and cab, both of length 3.

Use the "Sample 1: abccabcabcc" preset in the visualizer below to replay this case.

Input: aaaabaaa

Output: 2

Explanation: ab is the longest substring, with a length of 2.

Use the "Sample 2: aaaabaaa" preset in the visualizer below to replay this case.
*/
using System;

class Solution
{
    public static int LongestSubstringWithoutRepeatingCharacters(string s)
    {
        if(s.Length == 0){
            return 0;
        }
        int[] window = new int[75];
        window[s[0] - '0']++;
        int left = 0;
        int right = 0;
        int maxLen = 1;
        while(right < s.Length - 1){
            //expand window
            right++;
            window[s[right] - '0']++;
            //if window is invalid
            if(window[s[right] - '0'] > 1){
                //make window valid
                while(s[left] != s[right]){
                    window[s[left] - '0']--;
                    left++;
                }
                window[s[left] - '0']--;
                left++;
            }
            //update maxLen if necessary
            maxLen = Math.Max(maxLen, right - left + 1);
        }
        return maxLen;
    }
}
