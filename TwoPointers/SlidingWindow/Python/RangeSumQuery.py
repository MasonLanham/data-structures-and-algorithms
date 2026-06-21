'''
Given an integer array nums, calculate the sum of elements between indices left and right (inclusive). 
You need to answer multiple queries efficiently. You are required to preprocess the array so that each query can be answered in constant time.

Example: Input: nums = [1, 2, 3, 4], sumRange(1, 3). Output: 9.

Your function should return 9 because the sum of elements from index 1 to 3 is 2 + 3 + 4 = 9.
'''
def range_sum_query_immutable(prefix: list[int], left: int, right: int) -> int:
    return prefix[right + 1] - prefix[left]

def prefixSum(nums: list[int]) -> list[int]:
    prefix = [0]
    for i, num in enumerate(nums):
        prefix.append(prefix[i] + nums[i])
    return prefix
