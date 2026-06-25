'''Given two strings, original and check, return the shortest substring of original that contains every character in check, including duplicates. If multiple valid substrings have the same length, return the lexicographically smallest one.

Parameters
original: The source string.
check: The required characters.
Result
The minimum valid window in original.
Examples
Example 1
Input: original = "cdbaebaecd", check = "abc"

Output: baec

Explanation: Both cdba and baec are valid windows of length 4. We return baec because it is lexicographically smaller.

Constraints
1 <= len(check), len(original) <= 10^5
original and check contain only uppercase and lowercase English letters. Characters are case-sensitive.'''

def get_minimum_window(original: str, check: str):

    #Edge case easily taken care of.
    if(len(check) > len(original)):
        return ""
        
    left, right = 0, 0
    start, end = 0, len(original)

    #Creating a Map for the check string
    checkMap = [0] * 58
    for char in check:
        checkMap[ord(char) - ord('A')] += 1
        
    #Creating a Map representing the slice of the original we're checking
    originalSlice = [0] * 58
    originalSlice[ord(original[right]) - ord('A')] += 1

    #Traversing original string looking for valid windows
    while(right < len(original) - 1):
        if(validWindow(checkMap, originalSlice)):
            if(right - left < end - start):
                end, start = right, left
            elif(right - left == end - start and original[left:right+1] < original[start:end+1]):
                end, start = right, left
            originalSlice[ord(original[left]) - ord('A')] -= 1
            left += 1
        else:
            right += 1
            originalSlice[ord(original[right]) - ord('A')] += 1

    #Final Window check
    if(validWindow(checkMap, originalSlice)):
        if(right - left < end - start):
            end, start = right, left
        elif(right - left == end - start and original[left:right+1] < original[start:end+1]):
            end, start = right, left

    #If the end changed, then there was valid window
    if(end < len(original)):
        return original[start:end+1]
    else:
        return ""
        
#Helper function determines if this is a valid window
def validWindow(required: List, satisfied: List):
    for index, count in enumerate(required):
        if(count > 0 and satisfied[index] < count):
            return False
    return True
