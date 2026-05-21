/*
Flexible Size Sliding Window
Let's continue on finding the sum of subarrays. This time given a positive integer array nums, we want to find the length of the shortest subarray such that the subarray sum is at least target. 
Recall the same example with input nums = [1, 4, 1, 7, 3, 0, 2, 5] and target = 10, then the smallest window with the sum >= 10 is [7, 3] with length 2. So the output is 2.

We'll assume for this problem that it's guaranteed target will not exceed the sum of all elements in nums.
*/
function subarraySumShortest(nums, target) {
    let slow = 0;
    let fast = 0;
    let minLen = nums.length;
    let sum = nums[0];
    while(fast < nums.length){
        if(sum >= target){
            minLen = Math.min(minLen, fast - slow + 1);
            sum = sum - nums[slow];
            slow += 1;
        }
        else{
            fast += 1;
            if(fast < nums.length){
                sum += nums[fast];
            }
        }
    }
    return minLen;
}
