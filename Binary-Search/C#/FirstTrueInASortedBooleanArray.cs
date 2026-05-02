using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int FindBoundary(List<bool> arr)
    {
        int low = 0;
        int high = arr.Count - 1;
        int result = -1;
        while (low <= high){
            int mid = low + (high - low) / 2;
            if(arr[mid]){
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
