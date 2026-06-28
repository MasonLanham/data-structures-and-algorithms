/*
Teleporter Arrays
You are given two sorted arrays of distinct integers, arr1, and arr2. Your goal is to start from the beginning of one array, and arrive at the end of one array (it could be the same array or not).

For each step, you can either move forward a step on an array, or move to a square in the other array where the number is the same as the number in your current square ("teleportation"). Your total score is defined as the sum of all unique numbers that you have been on.

Find the maximum score that you can get given the above rules. Since the result might be very large and cause overflow, return the maximum score modded by 10^9 + 7.

Parameters
arr1: A list of ordered, distinct integers.
arr2: Another list of ordered, distinct integers.
Result
The maximum score possible, modded by 10^9 + 7.
Examples
Example 1
Input: arr1 = [2, 4, 5, 8, 10], arr2 = [4, 6, 8, 9]

Output: 30
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int MaximumScore(List<int> arr1, List<int> arr2)
    {
        //C# cannot handle numbers this large, so I constantly have to apply modulus
        long modulus = (long)(Math.Pow(10, 9)) + 7;
        
        int sum1 = 0;
        int sum2 = 0;
        int score = 0;
        int ptr1 = 0;
        int ptr2 = 0;
        while(ptr1 < arr1.Count && ptr2 < arr2.Count){
            //Searching for a teleport and keeping track of window
            if(arr1[ptr1] < arr2[ptr2]){
                sum1 = (int)((long)(sum1 + arr1[ptr1]) % modulus);
                ptr1 += 1;
            }
            else if(arr2[ptr2] < arr1[ptr1]){
                sum2 = (int)((long)(sum2 + arr2[ptr2]) % modulus);
                ptr2 += 1;
            }
            //Teleport found add larger sum to score
            else{
                score = (int)((long)(score + Math.Max(sum1, sum2)) % modulus);
                sum1 = arr1[ptr1];
                sum2 = arr2[ptr2];
                ptr1 += 1;
                ptr2 += 1;
            }
        }
        //Adding the largest sum after the last teleport
        while(ptr1 < arr1.Count){
            sum1 = (int)((long)(sum1 + arr1[ptr1]) % modulus);;
            ptr1 += 1;
        }
        while(ptr2 < arr2.Count){
            sum2 = (int)((long)(sum2 + arr2[ptr2]) % modulus);
            ptr2 += 1;
        }
        score = (int)((long)(score + Math.Max(sum1, sum2)) % modulus);
        return score;
    }
}
