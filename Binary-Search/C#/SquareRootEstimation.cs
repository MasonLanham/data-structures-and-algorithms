/*
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
        //Strategy -> Search space of 2 to n // 2
        //Check if estimate e satisfies e^2 <= n
        //return largest estimate not greater than sqrt(n)
        if(n == 0){return 0;}
        else if(n < 4){return 1;}
        else{
            int low = 2;
            int high = n / 2;
            int estimate;
            int estSqrd;
            int result = -1;
            while(low <= high){
                estimate = low + (high - low) / 2;
                estSqrd = estimate * estimate;
                if(estSqrd <= n){
                    result = estimate;
                    low = estimate + 1;
                }
                else{
                    high = estimate - 1;
                }
            }
            return result;
        }
    }
}
