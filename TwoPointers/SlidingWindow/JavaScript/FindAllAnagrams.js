/*
Given a string original and a string check, find the starting index of all substrings in original that are anagrams of check. Return the indices in ascending order.

Parameters
original: A string
check: A string
Result
A list of integers representing the starting indices of all anagrams of check.
Examples
Example 1
Input: original = "cbaebabacd", check = "abc"

Output: [0, 6]

Explanation: original[0:3] = "cba" and original[6:9] = "bac" each contain exactly the same letters as "abc" with different ordering.

Example 2
Input: original = "abab", check = "ab"

Output: [0, 1, 2]

Explanation: Every length-2 window in "abab" ("ab", "ba", "ab") is an anagram of "ab".

Constraints
1 <= len(original), len(check) <= 10^5
Each string consists of only lowercase characters in the standard English alphabet.
*/

function findAllAnagrams(original, check) {
    let checkMap = new Map();
    for(let i = 0; i < check.length; i++){
        checkMap = addToMap(checkMap, check[i]);
    }
    // Setting up sliding window on original
    let originalMap = new Map();
    for(let i = 0; i < check.length; i++){
        originalMap = addToMap(originalMap, original[i]);
    }
    // Maintain dictionary mapping character to count of character
    let result = [];
    for(let i = check.length; i < original.length + 1; i++){
        if(contentEqual(checkMap, originalMap)){
            result.push(i - check.length);
        }
        originalMap = addToMap(originalMap, original[i]);
        originalMap = subtractFromMap(originalMap, original[i - check.length]);
    }
    return result;
}

//function to add a character to a map
function addToMap(map, char){
    if(map.get(char) != undefined){
        map.set(char, map.get(char) + 1);
    }
    else{
        map.set(char, 1);
    }
    return map;
}

//function to subtract a character from a map
function subtractFromMap(map, char){
    if(map.get(char) > 1){
        map.set(char, map.get(char) - 1);
    }
    else{
        map.delete(char);
    }
    return map;
}

//function to check if maps structured as above are equal
function contentEqual(mapA, mapB){
    for (const key of mapA.keys()) {
        if(mapA.get(key) != mapB.get(key)){
            return false;
        }
    }
    for (const key of mapB.keys()) {
        if(mapB.get(key) != mapA.get(key)){
            return false;
        }
    }
    return true;
}
