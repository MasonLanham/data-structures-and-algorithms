/*
Given a string original and a string check, find the starting index of all substrings in original that are anagrams of check. Return the indices in ascending order.

Parameters
original: A string
check: A string
Result
A list of integers representing the starting indices of all anagrams of check.
Examples
Example 1
Input: original = "cbaebabacd", check = "abc"

Output: [0, 6]

Explanation: original[0:3] = "cba" and original[6:9] = "bac" each contain exactly the same letters as "abc" with different ordering.

Example 2
Input: original = "abab", check = "ab"

Output: [0, 1, 2]

Explanation: Every length-2 window in "abab" ("ab", "ba", "ab") is an anagram of "ab".

Constraints
1 <= len(original), len(check) <= 10^5
Each string consists of only lowercase characters in the standard English alphabet.
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static List<int> FindAllAnagrams(string original, string check)
    {
        //Invalid test case
        if(original.Length < check.Length){
            return new List<int>();
        }
        //Creating a map where index is the letter and value is amount for check
        int[] checkMap = new int[26];
        for(int i = 0; i < check.Length; i++){
            checkMap[(int)check[i] - 'a']++;
        }

        //initializing the window in the original string
        int right = 0;
        int[] window = new int[26];
        while(right < check.Length){
            window[(int)original[right] - 'a']++;
            right++;
        }

        //checking all windows if anagram
        int left = 0;
        List<int> result = new List<int>();
        while(right < original.Length){
            if(mapsEqual(checkMap, window)){
                result.Add(left);
            }
            window[(int)original[right] - 'a']++;
            right++;
            window[(int)original[left] - 'a']--;
            left++;
        }
        
        //check last index
        if(mapsEqual(checkMap, window)){
            result.Add(left);
        }
        return result;
    }

    public static bool mapsEqual(int[] map1, int[] map2){
        for(int i = 0; i < map1.Length; i++){
            if(map1[i] != map2[i]){
                return false;
            }
        }
        return true;
    }
}
