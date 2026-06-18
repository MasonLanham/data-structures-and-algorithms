/*
Given an integer array arr and a target value, return a subarray whose sum equals the target. Return the answer as [start, end), where start is inclusive and end is exclusive. If there are multiple valid answers, return the one with the smaller end value.

Input: arr = [1, -20, -3, 30, 5, 4], target = 7

Output: [1, 4]

The subarray arr[1:4] = [-20, -3, 30] sums to 7.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static List<int> SubarraySum(List<int> arr, int target)
    {
        List<int> prefixSums = new List<int>(new int[arr.Count + 1]);
        for(int i = 0; i < arr.Count; i++){
            prefixSums[i + 1] = prefixSums[i] + arr[i];
        }

        int sum;
        int complement;
        Dictionary<int, int> sums = new Dictionary<int, int>();
        for(int i = 0; i < prefixSums.Count; i++){
            sum = prefixSums[i];
            complement = sum - target;
            if(sums.TryGetValue(complement, out int startIndex)){
                return new List<int> {startIndex, i};
            }
            else{
                sums[sum] = i;
            }
        }
        return new List<int> {-1, -1};
    }
}
