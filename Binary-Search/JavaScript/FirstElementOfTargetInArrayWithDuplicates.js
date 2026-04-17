/*Given a sorted array of integers and a target integer, find the first occurrence of the target and return its index. Return -1 if the target is not in the array.

Input:

arr = [1, 3, 3, 3, 3, 6, 10, 10, 10, 100]
target = 3
Output: 1

Explanation: The first occurrence of 3 is at index 1.

Input:

arr = [2, 3, 5, 7, 11, 13, 17, 19]
target = 6
Output: -1

Explanation: 6 does not exist in the array.*/

function findFirstOccurrence(arr, target) {
    let low = 0;
    let high = arr.length - 1;
    let firstOccurrence = -1;
    while(low <= high){
        const mid = low + Math.floor((high - low) / 2);
        if(arr[mid] >= target){
            high = mid - 1;
            if(arr[mid] === target){
                firstOccurrence = mid;
            }
        }
        else{
            low = mid + 1;
        }
    }
    return firstOccurrence;
}
