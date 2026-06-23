/*
  Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

  Input: [1, 2, 3, 4].

  Output: [24, 12, 8, 6].
*/
class Solution
{
    public static List<int> ProductOfArrayExceptSelf(List<int> nums)
    {
        List<int> prefixMult = new List<int>(new int[nums.Count]);
        prefixMult[0] = nums[0];
        for(int i = 1; i < prefixMult.Count; i++){
            prefixMult[i] = prefixMult[i - 1] * nums[i];
        }
        
        List<int> postfixMult = new List<int>(new int[nums.Count]);
        postfixMult[postfixMult.Count - 1] = nums[nums.Count - 1];
        for(int i = postfixMult.Count - 2; i > -1; i--){
            postfixMult[i] = postfixMult[i + 1] * nums[i];
        }

        List<int> result = new List<int>(new int[nums.Count]);
        result[0] = postfixMult[1];
        result[result.Count - 1] = prefixMult[prefixMult.Count - 2];
        for(int i = 1; i < result.Count - 1; i++){
            result[i] = prefixMult[i - 1] * postfixMult[i + 1];
        }
        return result;
    }
}
