'''
Determine whether a string is a palindrome, ignoring non-alphanumeric characters and case. Examples:

Input: Do geese see God? Output: True

Input: Was it a car or a cat I saw? Output: True

Input: A brown fox jumping over Output: False
'''

def is_palindrome(s: str) -> bool:
    high, low = len(s) - 1, 0
    toCheckString = s.upper()
    while(low < high):
        while(not toCheckString[low:low+1].isalnum() and low < high):
            low += 1
        while(not toCheckString[high:high+1].isalnum() and low < high):
            high -= 1
        if(toCheckString[low:low+1] != toCheckString[high:high+1]):
            return False
        low += 1
        high -= 1
        
