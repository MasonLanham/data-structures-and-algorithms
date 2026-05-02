/*Given a sorted list of numbers with length at least 1, remove duplicates and return the new length. You must do this in-place and without using extra memory.

Input: [0, 0, 1, 1, 1, 2, 2].

Output: 3.

Your function should modify the list in place so that the first three elements become 0, 1, 2. Return 3 because the new length is 3.*/

function removeDuplicates(arr) {
    let slow = 0;
    let fast = 1;
    while(fast < arr.length){
        if(arr[slow] != arr[fast]){
            slow++;
            arr[slow] = arr[fast];
        }
        fast++;
    }
    return slow + 1;
}
