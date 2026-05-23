/*
Determine whether a string is a palindrome, ignoring non-alphanumeric characters and case. Examples:

Input: Do geese see God? Output: True

Input: Was it a car or a cat I saw? Output: True

Input: A brown fox jumping over Output: False
*/
using System;

class Solution
{
    public static bool IsPalindrome(string s){
        int low = 0;
        int high = s.Length - 1;
        while(low < high){
            while(low < high && !char.IsLetterOrDigit(s[low])){
                low += 1;
            }
            while(low < high && !char.IsLetterOrDigit(s[high])){
                high -= 1;
            }
            if(char.ToLower(s[low]) != char.ToLower(s[high])){
                return false;
            }
            low += 1;
            high -= 1;
        }
        return true;
    }
}
