/*
Given an array representing heights of vertical lines, find the maximum area of water trapped between two lines.

Input: [1,8,6,2,5,4,8,3,7].

Output: 49.

Your function should calculate the maximum area that can be trapped by two lines.
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int ContainerWithMostWater(List<int> arr)
    {
        int maxWater = 0;
        int left = 0;
        int right = arr.Count - 1;
        while(left < right){
            maxWater = Math.Max(maxWater, (right - left) * Math.Min(arr[left], arr[right]));
            if(arr[left] < arr[right]){
                left += 1;
            }
            else{
                right -= 1;
            }
        }
        return maxWater;
    }
}
