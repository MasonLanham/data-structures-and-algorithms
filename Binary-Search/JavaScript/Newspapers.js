/*
You have a stack of newspapers in a fixed order. Each newspaper has a read time. You want to assign all newspapers to a group of at most num_coworkers workers. Each worker is assigned a consecutive section of newspapers from the stack, and all workers read their assigned sections in parallel.

The constraint: you cannot reorder newspapers. If you assign newspapers at positions 1, 2, 3 to worker A, you cannot then assign newspaper 2 to worker B. Each worker gets a consecutive block from the original stack.

Find the minimum time needed to read all newspapers. Since workers read in parallel, the total time equals the time taken by the slowest worker.

For example, with newspapers [7,2,5,10,8] and 2 workers, you could assign [7,2,5] to worker A (14 minutes total) and [10,8] to worker B (18 minutes total). Worker B finishes last, so the answer is 18 minutes.*/

function newspapersSplit(newspapersReadTimes, numCoworkers) {
    let low = 0;
    let high = 0;
    for(let i = 0; i < newspapersReadTimes.length; i++){
        high += newspapersReadTimes[i];
        low = Math.max(low, newspapersReadTimes[i]);
    }
    let ans = high;
    while(low <= high){
        const mid = low + Math.floor((high - low) / 2);
        let i = 0;
        let currentTime = 0;
        let coworkersNeeded = 1;
        while(i < newspapersReadTimes.length){
            if(currentTime + newspapersReadTimes[i] > mid){
                coworkersNeeded += 1;
                currentTime = 0;
            }
            currentTime += newspapersReadTimes[i];
            i++;
        }
        //feasible
        if(coworkersNeeded <= numCoworkers){
            ans = mid;
            high = mid - 1;
        }
        else{
            low = mid + 1;
        }
    }
    return ans;
}

