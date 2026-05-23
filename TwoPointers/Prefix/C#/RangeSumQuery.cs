/*
Given an integer array nums, calculate the sum of elements between indices left and right (inclusive). 
You need to answer multiple queries efficiently. You are required to preprocess the array so that each query can be answered in constant time.

Example: Input: nums = [1, 2, 3, 4], sumRange(1, 3). Output: 9.

Your function should return 9 because the sum of elements from index 1 to 3 is 2 + 3 + 4 = 9.
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int RangeSumQueryImmutable(List<int> nums, int left, int right)
    {
        int[] preFix = new int[nums.Count + 1];
        preFix[0] = 0;
        for(int i = 1; i < nums.Count + 1; i++){
            preFix[i] = preFix[i - 1] + nums[i - 1];
        }
        return preFix[right + 1] - preFix[left];
    }
}
