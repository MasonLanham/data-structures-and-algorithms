/*
Recall finding the largest size k subarray sum of an integer array in Largest Subarray Sum. What if we don't need the largest sum among all subarrays of fixed size k, 
but instead, we want to find the length of the longest subarray with sum smaller than or equal to a target?
Given an array of non-negative integers nums = [1, 6, 3, 1, 2, 4, 5] and target = 10, the longest subarray that does not exceed 10 is [3, 1, 2, 4], so the output is 4.
*/
function subarraySumLongest(nums, target) {
    let slow = 0;
    let fast = 0;
    let sum = nums[0];
    let maxLength = 0;
    while(fast < nums.length){
        if(sum <= target){
            maxLength = Math.max(maxLength, fast - slow + 1);
            fast += 1;
            sum += nums[fast];
        }
        else{
            sum = sum - nums[slow];
            slow += 1;
        }
    }
    return maxLength;
}
