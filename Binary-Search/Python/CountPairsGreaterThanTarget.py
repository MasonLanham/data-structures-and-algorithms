#Solves the problem of counting the number of pairs in an array that sum to greater than a target.
#Can be solved simpler by using two pointers
import heapq, math

def pairsOverValue(arr, target):

    #heap sorting
    heap = []
    for i in range(len(arr)):
        heapq.heappush(heap, arr[i])

    sort = []
    for i in range(len(arr)):
        sort.append(heapq.heappop(heap))

    #binary search for boundary
    boundary = binarySearchRange(sort, 0, len(sort) - 1, target)
    n = len(sort) - boundary

    #For less than target
    low = 0
    totalPairs = math.floor((n * (n - 1)) / 2)
    currentValue = sort[low]
    minSearchIndex = binarySearchRange(sort, boundary, len(sort) - 1, target - currentValue)
    while(sort[low] < target):
        if(currentValue < sort[low]):
            #binary search on minSearchIndex to end of sort for the first value that satisfies x > target - currentValue
            currentValue = sort[low]
            minSearchIndex = binarySearchRange(sort, minSearchIndex, len(sort) - 1, target - currentValue)
        totalPairs += len(sort) - minSearchIndex
        low += 1
    
    #For equal to target
    targetsInSort = boundary - low + 1
    totalPairs += targetsInSort * (boundary - low)
    
    return totalPairs

    

def binarySearchRange(arr, startIndex, endIndex, target):
    low = startIndex
    high = endIndex
    boundary = -1
    while(low <= high):
        mid = low + math.floor((high - low) / 2)
        if(arr[mid] < target + 1):
            low = mid + 1
        else:
            boundary = mid
            high = mid - 1
    return boundary
