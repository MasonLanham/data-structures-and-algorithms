'''
Given an integer array nums, calculate the sum of elements between indices left and right (inclusive). You need to answer multiple queries efficiently. You are required to preprocess the array so that each query can be answered in constant time.

Example: Input: nums = [1, 2, 3, 4], sumRange(1, 3). Output: 9.

Your function should return 9 because the sum of elements from index 1 to 3 is 2 + 3 + 4 = 9.
'''

def prefix(nums: list[int]):
    ps = [0] * (len(nums) + 1)
    for i in range(len(nums)):
        ps[i + 1] = ps[i] + nums[i]
    return ps

def range_sum_query_immutable(nums: list[int], left: int, right: int) -> int:
    return nums[right + 1] - nums[left]
    
if __name__ == "__main__":
    nums = [int(x) for x in input().split()]
    left = int(input())
    right = int(input())
    nums = prefix(nums)
    res = range_sum_query_immutable(nums, left, right)
    print(res)
