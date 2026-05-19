/*
Given an array of integers, move all the 0s to the back of the array while maintaining the relative order of the non-zero elements. Do this in-place using constant auxiliary space.

Input:

[1, 0, 2, 0, 0, 7]
Output:

[1, 2, 7, 0, 0, 0]
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static void MoveZeros(List<int> nums)
    {
        int slow = 0;
        int fast = 0;
        int tmp = 0;
        while(fast < nums.Count){
            if(nums[fast] != 0){
                tmp = nums[slow];
                nums[slow] = nums[fast];
                nums[fast] = tmp;
                slow += 1;
            }
            fast += 1;
        }
    }
}
