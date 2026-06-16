/*
Flexible Size Sliding Window
Let's continue on finding the sum of subarrays. This time given a positive integer array nums, we want to find the length of the shortest subarray such that the subarray sum is at least target. Recall the same example with input nums = [1, 4, 1, 7, 3, 0, 2, 5] and target = 10, then the smallest window with the sum >= 10 is [7, 3] with length 2. So the output is 2.

We'll assume for this problem that it's guaranteed target will not exceed the sum of all elements in nums.
*/
using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    public static int SubarraySumShortest(List<int> nums, int target)
    {
        int left = 0;
        int right = 1;
        int sum = nums[0];
        int minLen = nums.Count;
        while(right < nums.Count){
            while(sum < target && right < nums.Count){
                sum += nums[right];
                right++;
            }
            while(sum >= target){
                sum -= nums[left];
                left++;
            }
            minLen = Math.Min(minLen, right - left + 1);
        }
        return minLen;
    }
}
