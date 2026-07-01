/*
Given an array of integers, move all the 0s to the back of the array while maintaining the relative order of the non-zero elements. Do this in-place using constant auxiliary space.

Input:

[1, 0, 2, 0, 0, 7]
Output:

[1, 2, 7, 0, 0, 0]
*/
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

class Solution {
    public static void moveZeros(List<Integer> nums) {
        int slow = 0;
        int fast = 0;
        int tmp;
        while(fast < nums.size()){
            if(nums.get(fast) != 0){
                tmp = nums.get(slow);
                nums.set(slow, nums.get(fast));
                nums.set(fast, tmp);
                slow++;
            }
            fast++;
        }
    }
}
