A sorted array of unique integers was rotated at an unknown pivot. For example, [10, 20, 30, 40, 50] becomes [30, 40, 50, 10, 20]. Find the index of the minimum element in this array.

Input: [30, 40, 50, 10, 20]

Output: 3

Explanation: The smallest element is 10, and its index is 3.

Input: [3, 5, 7, 11, 13, 17, 19, 2]

Output: 7

Explanation: The smallest element is 2, and its index is 7.

function findMinRotated(arr) {
    let high = arr.length - 1;
    let low = 0;
    let ans = high;
    while(low <= high){
        const mid = low + Math.floor((high - low) / 2);
        if(arr[mid] <= arr[arr.length - 1]){
            ans = mid;
            high = mid - 1;
        }
        else{
            low = mid + 1;
        }
    }
    return ans;
}

Why does this work?
Binary search works as long as there is a binary decision we can use to shrink the search range. When the sorted array is rotated, it can be seen as having two sections: one that has items larger than the last element, and one that items less than the last element. Therefore we only need to search the section that is smaller than the last element, and the only feasible elements are those that are less than the last element.