'''
Given a phone number that contains digits 2-9, find all possible letter combinations the phone number could translate to.

Input:
"56"

Output:
["jm","jn","jo","km","kn","ko","lm","ln","lo"]
'''
def dfs_pather(digitsLeft: str, digitMap: dict, path: str) -> list[str]:
    if digitsLeft == "":
        return [path]
    paths = []
    for char in digitMap[digitsLeft[0]]:
        paths += dfs_pather(digitsLeft[1:], digitMap, path + char)
    return paths

        
def letter_combinations_of_phone_number(digits: str) -> list[str]:
    digitMap = {'2': 'abc','3': 'def','4': 'ghi','5': 'jkl','6': 'mno','7': 'pqrs','8': 'tuv','9': 'wxyz'}
    return dfs_pather(digits, digitMap, "")
