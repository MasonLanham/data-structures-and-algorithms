'''Given an array of integers, move all the 0s to the back of the array while maintaining the relative order of the non-zero elements. Do this in-place using constant auxiliary space.

Input:

[1, 0, 2, 0, 0, 7]
Output:

[1, 2, 7, 0, 0, 0]'''

def move_zeros(nums: list[int]) -> None:
    zeroPointer, nonZeroPointer, tmp = 0, 0, 0
    while(nonZeroPointer < len(nums)):
        tmp = nums[nonZeroPointer]
        nums[nonZeroPointer] = nums[zeroPointer]
        nums[zeroPointer] = tmp
        if(nums[zeroPointer] != 0):
            zeroPointer += 1
        nonZeroPointer += 1
