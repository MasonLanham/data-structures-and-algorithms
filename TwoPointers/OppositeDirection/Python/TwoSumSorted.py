'''
Given an array of integers sorted in ascending order, find two numbers that add up to a given target. Return the indices of the two numbers in ascending order. You can assume elements in the array are unique and there is only one solution. Do this in O(n) time and with constant auxiliary space.

Input:

arr: a sorted integer array
target: the target sum we want to reach
Sample Input: [2, 3, 4, 5, 8, 11, 18], 8

Sample Output: 1 3
'''

def two_sum_sorted(arr: list[int], target: int) -> list[int]:
    high = len(arr) - 1
    low = 0
    while(high > low):
        sum = arr[low] + arr[high]
        if sum == target:
            break
        elif sum < target:
            low += 1
        else: 
            high -= 1
    return low, high
