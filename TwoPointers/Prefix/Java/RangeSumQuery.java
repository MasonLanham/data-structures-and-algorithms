/*
Given an integer array nums, calculate the sum of elements between indices left and right (inclusive). You need to answer multiple queries efficiently. You are required to preprocess the array so that each query can be answered in constant time.

Example: Input: nums = [1, 2, 3, 4], sumRange(1, 3). Output: 9.

Your function should return 9 because the sum of elements from index 1 to 3 is 2 + 3 + 4 = 9.
*/
import java.util.Arrays;
import java.util.List;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.Collections;

class Solution {
    public static int rangeSumQueryImmutable(List<Integer> nums, int left, int right) {
        List<Integer> forward = new ArrayList<Integer>(Collections.nCopies(nums.size() + 1, 0));
        
        //forward subarray sum
        for(int i = 1; i < nums.size() + 1; i++){
            forward.set(i, nums.get(i - 1) + forward.get(i - 1));
        }
        return forward.get(right + 1) - forward.get(left);
    }

    public static List<String> splitWords(String s) {
        return s.isEmpty() ? List.of() : Arrays.asList(s.split(" "));
    }

    public static void main(String[] args) {
        java.util.Scanner scanner = new java.util.Scanner(System.in);
        List<Integer> nums = splitWords(scanner.nextLine()).stream().map(Integer::parseInt).collect(Collectors.toList());
        int left = Integer.parseInt(scanner.nextLine());
        int right = Integer.parseInt(scanner.nextLine());
        scanner.close();
        int res = rangeSumQueryImmutable(nums, left, right);
        System.out.println(res);
    }
}
