def find_all_anagrams(original: str, check: str) -> list[int]:
    anagramStarts = []
    if(len(original) < len(check)):
        return anagramStarts
        
    #initializing checkMap to map the check string
    checkMap = [0] * 26
    for i in range(len(check)):
        checkMap[ord(check[i]) - ord('a')] += 1
    
    #initializing oriMap to the first substring of that length in original
    oriMap = [0] * 26
    for i in range(len(check)):
        oriMap[ord(original[i]) - ord('a')] += 1
        
    if(areEqual(oriMap,checkMap)):
       anagramStarts.append(0)

    i = len(check) - 1
    while i < len(original) - 1:
        windowStart = i - (len(check) - 1)
        oriMap[ord(original[windowStart]) - ord('a')] -= 1
        i += 1
        oriMap[ord(original[i]) - ord('a')] += 1
        if areEqual(oriMap, checkMap):
            anagramStarts.append(windowStart + 1)
    
    return anagramStarts
