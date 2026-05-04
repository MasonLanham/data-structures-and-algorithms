/*
Square Root Estimation
Prereq: First True in a Sorted Boolean Array

Given an integer, find its square root without using the built-in square root function. Only return the integer part (truncate the decimals).

Input: 16

Output: 4

Input: 8

Output: 2

Explanation: square root of 8 is 2.83..., return the integer part, 2
*/
using System;

class Solution
{
    public static int SquareRoot(int n)
    {
        if(n == 0){return 0;}
        else if(n == 1){return 1;}
        else if(n <= 4){return 2;}
        else{
            int low = 3;
            int high = n / 2;
            int mid;
            int result = -1;
            while (low <= high){
                mid = low + (high - low) / 2;
                int midSq = mid * mid;
                if(midSq == n){
                    return mid;
                }
                else if(midSq > n){
                    result = mid - 1;
                    high = mid - 1;   
                }
                else{
                    low = mid + 1;
                }
            }
            return result;
        }
    }
}
