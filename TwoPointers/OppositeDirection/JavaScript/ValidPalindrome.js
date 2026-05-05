/*Determine whether a string is a palindrome, ignoring non-alphanumeric characters and case. Examples:

Input: Do geese see God? Output: True

Input: Was it a car or a cat I saw? Output: True

Input: A brown fox jumping over Output: False*/

function isPalindrome(s) {
    let low = 0;
    let high = s.length - 1;
    while(low < high){
        let code = s.charCodeAt(low);
        while(!isAlphaNumeric(code) && low < high){
            low += 1;
            code = s.charCodeAt(low);
        }
        code = s.charCodeAt(high);
        while(!isAlphaNumeric(code) && low < high){
            high = high - 1;
            code = s.charCodeAt(high);
        }
        if(s[low].toLowerCase() === s[high].toLowerCase()){
            high = high - 1;
            low = low + 1;
           }
        else{
            return false;
        }
    }
return true;
}
