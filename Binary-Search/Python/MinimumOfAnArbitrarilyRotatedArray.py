'''A sorted array of unique integers was rotated at an unknown pivot. For example, [10, 20, 30, 40, 50] becomes [30, 40, 50, 10, 20]. Find the index of the minimum element in this array.

Input: [30, 40, 50, 10, 20]

Output: 3

Explanation: The smallest element is 10, and its index is 3.

Input: [3, 5, 7, 11, 13, 17, 19, 2]

Output: 7

Explanation: The smallest element is 2, and its index is 7.'''

import math

def find_min_rotated(arr: list[int]) -> int:
    last = arr[-1]
    low = 0
    high = len(arr) - 1
    result = high
    while(low <= high):
        mid = low + math.floor((high - low) / 2)
        if(arr[mid] > last):
            low = mid + 1;
        elif(arr[mid] <= last):
            result = mid
            high = mid - 1
    return result

if __name__ == "__main__":
    arr = [int(x) for x in input().split()]
    res = find_min_rotated(arr)
    print(res)
