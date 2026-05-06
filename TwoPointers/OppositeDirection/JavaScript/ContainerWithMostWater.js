/*
Given an array representing heights of vertical lines, find the maximum area of water trapped between two lines.

Input: [1,8,6,2,5,4,8,3,7].

Output: 49.
*/

function containerWithMostWater(arr) {
    let low = 0;
    let high = arr.length - 1;
    let maxWater = -1;
    while(low < high){
        const water = Math.min(arr[low], arr[high]) * (high - low);
        maxWater = Math.max(water, maxWater);
        if(arr[low] < arr[high]){
            low = low + 1;
        }
        else{
            high = high - 1;
        }
    }
    return maxWater;
}
