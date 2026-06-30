'''Given an array of integers, move all the 0s to the back of the array while maintaining the relative order of the non-zero elements. Do this in-place using constant auxiliary space.

Input:

[1, 0, 2, 0, 0, 7]
Output:

[1, 2, 7, 0, 0, 0]'''

def move_zeros(nums: list[int]) -> None:
    slow, fast, tmp = 0, 0, 0
    while(fast < len(nums)):
        #Slow pointer must always point to the first zero in the array before swap (this maintains the order)
        if(nums[fast] != 0):
            tmp = nums[slow]
            nums[slow] = nums[fast]
            nums[fast] = tmp
            slow += 1
        fast += 1       
