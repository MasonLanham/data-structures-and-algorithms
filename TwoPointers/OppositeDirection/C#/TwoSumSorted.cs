/*
Given an array of integers sorted in ascending order, find two numbers that add up to a given target. Return the indices of the two numbers in ascending order. You can assume elements in the array are unique and there is only one solution. Do this in O(n) time and with constant auxiliary space.

Input:

arr: a sorted integer array
target: the target sum we want to reach
Sample Input: [2, 3, 4, 5, 8, 11, 18], 8

Sample Output: 1 3
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static List<int> TwoSumSorted(List<int> arr, int target)
    {
        int high = arr.Count - 1;
        int low = 0;
        int sum = 0;
        while(high > low){
            sum = arr[low] + arr[high];
            if(sum > target){
                high -=1;
            }
            else if(sum < target){
                low += 1;
            }
            else{
                break;
            }
        }
        int[] result = {low, high};
        return new List<int>(result);
    }
}
