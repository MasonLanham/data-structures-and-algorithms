'''
Given a positive integer array nums, we want to find the length of the shortest subarray such that the subarray sum is at least target.
Recall the same example with input nums = [1, 4, 1, 7, 3, 0, 2, 5] and target = 10, then the smallest window with the sum >= 10 is [7, 3] with length 2. So the output is 2.

We'll assume for this problem that it's guaranteed target will not exceed the sum of all elements in nums.
'''
def subarray_sum_shortest(nums: list[int], target: int) -> int:
    left = 0
    right = 0
    sum = 0
    minLength = len(nums)
    while(right < len(nums)):
        sum += nums[right]
        while(sum >= target):
            minLength = min(minLength, right - left + 1)
            sum -= nums[left]
            left += 1 
        right += 1
    return minLength
