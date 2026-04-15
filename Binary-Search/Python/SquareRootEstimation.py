'''
Given an integer, find its square root without using the built-in square root function. Only return the integer part (truncate the decimals).

Input: 16

Output: 4

Input: 8

Output: 2

Explanation: square root of 8 is 2.83..., return the integer part, 2
'''
import math

def square_root(n: int) -> int:
    if(n == 0):
        return 0
    elif(n <= 3):
        return 1
    high = n/2
    low = 2
    while(low <= high):
        mid = low + math.floor((high - low) / 2)
        square = mid ** 2
        if(square < n):
            low = mid + 1
        elif(square == n):
            return mid
        elif((mid - 1) ** 2 < n):
            return mid - 1
        else:
            high = mid - 1
            
    return -1

if __name__ == "__main__":
    n = int(input())
    res = square_root(n)
    print(res)
