/*
Flexible Size Sliding Window - Longest
Recall finding the largest size k subarray sum of an integer array in Largest Subarray Sum. 
What if we don't need the largest sum among all subarrays of fixed size k, but instead, 
we want to find the length of the longest subarray with sum smaller than or equal to a target?

Given an array of non-negative integers nums = [1, 6, 3, 1, 2, 4, 5] and target = 10, the longest subarray that does not exceed 10 is [3, 1, 2, 4], so the output is 4.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int SubarraySumLongest(List<int> nums, int target)
    {
        int left = 0;
        int right = 0;
        int maxLen = 1;
        int sum = nums[0];
        while(right < nums.Count - 1){
            if(nums[right + 1] <= target - sum){
                right += 1;
                sum += nums[right];
                maxLen = Math.Max(maxLen, right - left + 1);
            }
            else{
                sum -= nums[left];
                left += 1;
            }
        }
        return maxLen;
    }
}
