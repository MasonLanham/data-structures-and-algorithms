/*
Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

Input: [1, 2, 3, 4].

Output: [24, 12, 8, 6].
*/

function productOfArrayExceptSelf(nums) {

    //calculating prefix product array
    const prefix = new Array(nums.length);
    prefix[0] = 1;
    for(let i = 1; i < nums.length; i++)
    {
        prefix[i] = prefix[i - 1] * nums[i - 1];
    }

    //calculating suffix product array
    const suffix = new Array(nums.length);
    suffix[nums.length - 1] = 1;
    for(let i = nums.length - 2; i >= 0; i--){
        suffix[i] = suffix[i + 1] * nums[i + 1];
    }

    const result = new Array(nums.length);
    result[0] = suffix[0];
    result[nums.length - 1] = prefix[nums.length - 1];
    for(let i = 0; i < nums.length - 1; i++){
        result[i] = prefix[i] * suffix[i];
    }
    return result;
}
