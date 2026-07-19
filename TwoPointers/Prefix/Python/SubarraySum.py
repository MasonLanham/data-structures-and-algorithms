'''
Given an integer array arr and a target value, return a subarray whose sum equals the target. Return the answer as [start, end), where start is inclusive and end is exclusive. If there are multiple valid answers, return the one with the smaller end value.

Input: arr = [1, -20, -3, 30, 5, 4], target = 7

Output: [1, 4]

The subarray arr[1:4] = [-20, -3, 30] sums to 7.
'''
def subarray_sum(arr: list[int], target: int) -> list[int]:
    #Creating Prefix Sum
    pre = [0]
    sum = 0
    for num in arr:
        sum += num
        pre.append(sum)
        
    #Finding the complement (searching for the range)
    preDict = {}
    for i, num in enumerate(pre):
        complement = num - target
        if complement in preDict:
            return [preDict[complement], i]
        else:
            preDict[num] = i
    return []
