/*
You have a stack of newspapers in a fixed order. Each newspaper has a read time. You want to assign all newspapers to a group of at most num_coworkers workers. Each worker is assigned a consecutive section of newspapers from the stack, and all workers read their assigned sections in parallel.

The constraint: you cannot reorder newspapers. If you assign newspapers at positions 1, 2, 3 to worker A, you cannot then assign newspaper 2 to worker B. Each worker gets a consecutive block from the original stack.

Find the minimum time needed to read all newspapers. Since workers read in parallel, the total time equals the time taken by the slowest worker.

For example, with newspapers [7,2,5,10,8] and 2 workers, you could assign [7,2,5] to worker A (14 minutes total) and [10,8] to worker B (18 minutes total). Worker B finishes last, so the answer is 18 minutes.

Constraints
1 <= newspapers_read_times.length <= 10^5

1 <= newspapers_read_times[i] <= 10^5

1 <= num_coworkers <= 10^5

Examples
Example 1:
Input: newspapers_read_times = [7,2,5,10,8], num_coworkers = 2
Output: 18
Explanation:
Assign first 3 newspapers to one coworker then assign the rest to another. The time it takes for the first 3 newspapers is 7 + 2 + 5 = 14 and for the last 2 is 10 + 8 = 18.

Example 2:
Input: newspapers_read_times = [2,3,5,7], num_coworkers = 3
Output: 7
Explanation:
Assign [2, 3], [5], and [7] separately to workers. The minimum time is 7.
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int NewspapersSplit(List<int> newspapersReadTimes, int numCoworkers)
    {
        int low = newspapersReadTimes.Max();
        int high = newspapersReadTimes.Sum();
        int estimatedReadTime;
        int result = -1;
        while(low <= high){
            estimatedReadTime = low + (high - low) / 2;
            //feasible function
            int workersRequired = 1;
            int workerReadTime = 0;
            for(int i = 0; i < newspapersReadTimes.Count; i++){
                workerReadTime += newspapersReadTimes[i];
                if(workerReadTime > estimatedReadTime){
                    workersRequired += 1;
                    workerReadTime = newspapersReadTimes[i];
                }
            }
            if(workersRequired > numCoworkers){
                low = estimatedReadTime + 1;
            }
            else{
                result = estimatedReadTime;
                high = estimatedReadTime - 1;
            }
        }
        return result;
    }
}
