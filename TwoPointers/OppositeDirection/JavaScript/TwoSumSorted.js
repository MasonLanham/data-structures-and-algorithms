/*
Given an array of integers sorted in ascending order, find two numbers that add up to a given target. Return the indices of the two numbers in ascending order. You can assume elements in the array are unique and there is only one solution. Do this in O(n) time and with constant auxiliary space.

Input:

arr: a sorted integer array
target: the target sum we want to reach
Sample Input: [2, 3, 4, 5, 8, 11, 18], 8

Sample Output: 1 3
*/
function twoSumSorted(arr, target) {
    let low = 0;
    let high = arr.length - 1;
    while(low < high){
        const sum = arr[low] + arr[high];
        if(sum > target){
            high = high - 1;
        }
        else if(sum < target){
            low = low + 1;
        }
        else{
            break;
        }
    }
    return [low, high];
}
