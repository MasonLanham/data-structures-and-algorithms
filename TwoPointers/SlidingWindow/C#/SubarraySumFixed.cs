/*
Given an array (list) nums consisted of only non-negative integers, find the largest sum among all subarrays of length k in nums.

For example, if the input is nums = [1, 2, 3, 7, 4, 1], k = 3, then the output would be 14 as the largest length 3 subarray sum is given by [3, 7, 4] which sums to 14.
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int SubarraySumFixed(List<int> nums, int k)
    {
        int left = 0;
        int right = 0;
        int maxSum = 0;
        while(right < k){
            maxSum += nums[right];
            right++;
        }
        int sum = maxSum;
        while(right < nums.Count){
            sum -= nums[left];
            left++;
            sum += nums[right];
            right++;
            maxSum = Math.Max(maxSum, sum);
        }
        return maxSum;
    }
}
