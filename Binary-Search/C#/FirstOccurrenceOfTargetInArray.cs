/*
Given a sorted array of integers and a target integer, find the first occurrence of the target and return its index. Return -1 if the target is not in the array.

Input:

arr = [1, 3, 3, 3, 3, 6, 10, 10, 10, 100]
target = 3
Output: 1

Explanation: The first occurrence of 3 is at index 1.

Input:

arr = [2, 3, 5, 7, 11, 13, 17, 19]
target = 6
Output: -1

Explanation: 6 does not exist in the array.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int FindFirstOccurrence(List<int> arr, int target)
    {
        int low = 0;
        int high = arr.Count - 1;
        int mid;
        int result = -1;
        while(low <= high){
            mid = low + (high - low) / 2;
            if(arr[mid] >= target){
                high = mid - 1;
                if(arr[mid] == target){
                    result = mid;
                }
            }
            else{
                low = mid + 1;
            }
        }
        return result;
    }
}
