/*
Given an array (list) nums consisted of only non-negative integers, find the largest sum among all subarrays of length k in nums.
For example, if the input is nums = [1, 2, 3, 7, 4, 1], k = 3, then the output would be 14 as the largest length 3 subarray sum is given by [3, 7, 4] which sums to 14.
*/

function subarraySumFixed(nums, k) {
    let window = 0;
    //first loop sums up window
    for(let i = 0; i < k; i++){
        window += nums[i];
    }
    //second loop maintains the sliding window until each window checked.
    let maxWindow = window;
    let i = k;
    while(i < nums.length){
        window = window - nums[i - k];
        window = window + nums[i];
        maxWindow = Math.max(window, maxWindow);
        i++;
    }
    return maxWindow;
}
