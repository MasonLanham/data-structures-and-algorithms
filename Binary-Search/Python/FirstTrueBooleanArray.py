'''
An array of boolean values is divided into two sections: The left section consists of all false, and the right section consists of all true. Find the First True in a Sorted Boolean Array of the right section, i.e., the index of the first true element. If there is no true element, return -1.

Input: arr = [false, false, true, true, true]

Output: 2

Explanation: The first true's index is 2.
'''

def find_boundary(arr: list[bool]) -> int:
    firstTrue = -1
    low = 0
    high = len(arr) - 1
    while low <= high:
        mid = low + (high - low) // 2
        if arr[mid]:
            firstTrue = mid
            high = mid - 1
        else:
            low = mid + 1        
    return firstTrue
