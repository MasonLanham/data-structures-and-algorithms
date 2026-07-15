'''
Recall finding the largest size k subarray sum of an integer array in Largest Subarray Sum. 
What if we don't need the largest sum among all subarrays of fixed size k, but instead, we want to find the length of the longest subarray with sum smaller than or equal to a target?

Given an array of non-negative integers nums = [1, 6, 3, 1, 2, 4, 5] and target = 10, the longest subarray that does not exceed 10 is [3, 1, 2, 4], so the output is 4.'''
def subarray_sum_longest(nums: list[int], target: int) -> int:
    low = 0
    high = 0
    sum = nums[0]
    longest = 1
    while high < len(nums) - 1:
        if sum < target:
            high += 1
            sum += nums[high]
        else:
            sum -= nums[low]
            low += 1
        if sum <= target:
            longest = max(longest, high - low + 1)
    return longest
