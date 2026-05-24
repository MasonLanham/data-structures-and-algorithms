/*
Given an integer array nums, calculate the sum of elements between indices left and right (inclusive). 
You need to answer multiple queries efficiently. 
You are required to preprocess the array so that each query can be answered in constant time.

Example: Input: nums = [1, 2, 3, 4], sumRange(1, 3). Output: 9.

Your function should return 9 because the sum of elements from index 1 to 3 is 2 + 3 + 4 = 9.
*/

function preFixSum(nums){
    let preFix = [0];
    for(let i = 0; i < nums.length; i++){
        preFix.push(preFix[i] + nums[i]);
    }
    return preFix;
}

function rangeSumQueryImmutable(nums, left, right) {
    const preFix = preFixSum(nums);
    return preFix[right + 1] - preFix[left];
}
