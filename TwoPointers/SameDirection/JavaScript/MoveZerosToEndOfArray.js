/*
Given an array of integers, move all the 0s to the back of the array while maintaining the relative order of the non-zero elements. Do this in-place using constant auxiliary space.

Input:

[1, 0, 2, 0, 0, 7]
Output:

[1, 2, 7, 0, 0, 0] */

function moveZeros(nums) {
    let slow = 0;
    let fast = 0;
    while(fast < nums.length){
        if(nums[fast] !== 0){
            const tmp = nums[fast];
            nums[fast] = nums[slow];
            nums[slow] = tmp;
            slow += 1;            
        }
        fast += 1;
    }
}
