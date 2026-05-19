
function longestSubstringWithoutRepeatingCharacters(s) {
    let checkMap = new Map();
    let slow = 0;
    let fast = 0;
    let maxLength = 0;
    while(fast < s.length){
        if(checkMap.get(s[fast]) == undefined){
            addToMap(checkMap, s[fast]);
            fast += 1;
            maxLength = Math.max(maxLength, fast - slow);
        }
        else{
            subtractFromMap(checkMap, s[slow])
            slow += 1;
        }
    }
    return maxLength;
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
