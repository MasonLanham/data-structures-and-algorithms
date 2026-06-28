'''
Given a sorted list of numbers with length at least 1, remove duplicates and return the new length. You must do this in-place and without using extra memory.

Input: [0, 0, 1, 1, 1, 2, 2].

Output: 3.

Your function should modify the list in place so that the first three elements become 0, 1, 2. Return 3 because the new length is 3.
'''
def remove_duplicates(arr: list[int]) -> int:
    slow = 0
    fast = 0
    while(fast < len(arr)):
        if(arr[slow] != arr[fast]):
            slow += 1
            arr[slow] = arr[fast]
        fast += 1
    return slow + 1
