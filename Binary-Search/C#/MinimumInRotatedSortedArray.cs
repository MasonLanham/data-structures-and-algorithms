/*
A sorted array of unique integers was rotated at an unknown pivot. For example, [10, 20, 30, 40, 50] becomes [30, 40, 50, 10, 20]. Find the index of the minimum element in this array.

Input: [30, 40, 50, 10, 20]

Output: 3

Explanation: The smallest element is 10, and its index is 3.

Input: [3, 5, 7, 11, 13, 17, 19, 2]

Output: 7

Explanation: The smallest element is 2, and its index is 7.
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int FindMinRotated(List<int> arr)
    {
        int low = 0;
        int high = arr.Count - 1;
        int result = -1;
        int mid;
        while(low <= high){
            mid = low + (high - low) / 2;
            if(arr[mid] <= arr[arr.Count - 1]){
                result = mid;
                high = mid - 1;
            }
            else{
                low = mid + 1;
            }
        }
        return result;
    }
}
