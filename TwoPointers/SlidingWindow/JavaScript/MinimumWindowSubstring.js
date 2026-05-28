/*
Given two strings, original and check, return the shortest substring of original that contains every character in check, including duplicates. If multiple valid substrings have the same length, return the lexicographically smallest one.

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
original and check contain only uppercase and lowercase English letters. Characters are case-sensitive.
*/
function getMinimumWindow(original, check) {
    
    //Setting up map of the string to be checked against
    const checkMap = new Array(52).fill(0);
    for(let i = 0; i < check.length; i++){
        checkMap[check.charCodeAt(i) - 65]++;
    }

    //Setting up original map
    const originalMap = new Array(52).fill(0);
    for(let i = 0; i < check.length; i++){
        originalMap[original.charCodeAt(i) - 65]++;
    }

    //Sliding the window
    let resultL = 0;
    let resultR = original.length;
    let left = 0;
    let right = check.length - 1;
    while(right < original.length){
        //Valid window check if could be a result
        if(containsCheck(originalMap, checkMap)){
            //Smallest window or Lexigraphically smaller and equal size
            if(resultR - resultL > right - left || 
               (resultR - resultL == right - left && 
                original.substring(resultL, resultR + 1) > original.substring(left, right))){
                resultL = left, resultR = right;
            }
            originalMap[original.charCodeAt(left) - 65]--;
            left++;
        }
        //Invalid window, must expand
        else{
            right++;
            if(right < original.length){
                originalMap[original.charCodeAt(right) - 65]++;
            }
        }
    }
    //Checking if valid window ever found
    if(resultR < original.length){
        return original.substring(resultL, resultR + 1);
    }
    else{
        return "";
    }

}

function containsCheck(originalMap, checkMap){
    for(let i = 0; i < checkMap.length; i++){
        if(checkMap[i] > originalMap[i]){
            return false;
        }
    }
    return true;
}
