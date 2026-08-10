/*
Given an integer array arr and a target value, return a subarray whose sum equals the target. Return the answer as [start, end), where start is inclusive and end is exclusive.

Input: arr = [1, -20, -3, 30, 5, 4], target = 7
Output: [1, 4]

The subarray arr[1:4] = [-20, -3, 30] sums to 7.
*/
function subarraySum(arr, target) {
    //Creating prefix sum
    let ps = new Array(arr.length + 1).fill(0);
    for(let i = 0; i < arr.length; i++){
        ps[i + 1] = arr[i] + ps[i];
    }
    
    //Maintain a dictionary to lookup the compliment
    //Compliment = ps[j] - target
    const lookup = new Map();
    for(let j = 0; j < ps.length; j++){
        const complimentLocation = lookup.get(ps[j] - target);
        if(complimentLocation != undefined){
            return [complimentLocation, j]
        }
        lookup.set(ps[j], j);
    }
    return [-1, -1];
}
