'''
Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

Input: [1, 2, 3, 4].

Output: [24, 12, 8, 6].
'''
def product_of_array_except_self(nums: list[int]) -> list[int]:
    #Creating an array where each element is the multiplication of all elements before it.
    preFM = [1] * (len(nums) + 1)
    for i in range(len(nums)):
        preFM[i + 1] = preFM[i] * nums[i]
      
    #Creating an array where each element is the multiplication of all elements after it.
    postFM = [1] * (len(nums) + 1)
    for i in range(len(nums) - 1, -1, -1):
        postFM[i - 1] = postFM[i] * nums[i]

    #Filling the rsult array with the product of everything except for what's at index i.
    result = [1] * len(nums)
    result[0] = postFM[0]
    result[-1] = preFM[len(nums) - 1]
    for i in range(1, len(nums) -1, 1):
        result[i] = preFM[i] * postFM[i]
    return result
