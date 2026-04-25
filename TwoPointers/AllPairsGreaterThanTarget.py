#Given an array and a target, count the pairs of integers that sum to greater than the target in the array.

import heapq, math

def pairsOverValue(arr, target):

    #heap sorting
    heap = []
    for i in range(len(arr)):
        heapq.heappush(heap, arr[i])

    sort = []
    for i in range(len(arr)):
        sort.append(heapq.heappop(heap))

    high = len(sort) - 1
    low = 0
    totalPairs = 0
    while(low < high):
        if(sort[low] + sort[high] > target):
            totalPairs += high - low
            high -= 1
        else:
            low += 1
    return totalPairs
