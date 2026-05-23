/*
Given an integer array arr and a target value, return a subarray whose sum equals the target. Return the answer as [start, end), where start is inclusive and end is exclusive.

Input: arr = [1, -20, -3, 30, 5, 4], target = 7
Output: [1, 4]

The subarray arr[1:4] = [-20, -3, 30] sums to 7.
*/
function subarraySum(arr, target) {
    let preFix = [0, arr[0]];
    for(let i = 1; i < arr.length; i++){
        preFix.push(arr[i] + preFix[i]);
    }
    let preFixSet = new Map();
    for(let j = 0; j < preFix.length; j++){
        if(preFixSet.get(preFix[j] - target) != undefined){
            const result = [preFixSet.get(preFix[j] - target), j];
            return result;
        }
        else{
            preFixSet.set(preFix[j], j);
        }
    }
    const result = [-1, -1]
    return result;
}
/*
Why this works: 
Define prefix[k] as the sum of the first k elements, so prefix[0] = 0 and prefix[k] = arr[0] + ... + arr[k-1].
For any subarray arr[i:j], its sum is:

prefix[j] - prefix[i]

This turns the goal into finding indices i < j such that:
prefix[j] - prefix[i] = target

Rearranged:
prefix[i] = prefix[j] - target

Once you fix j, you only need to know whether prefix[j] - target appeared earlier.
*/
