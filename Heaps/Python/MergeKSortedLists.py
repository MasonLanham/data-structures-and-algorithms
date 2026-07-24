'''
Given k sorted lists of numbers, merge them into one sorted list.

Input: [[1, 3, 5], [2, 4, 6], [7, 10]]

Output: [1, 2, 3, 4, 5, 6, 7, 10]
'''
import heapq
def merge_k_sorted_lists(lists: list[list[int]]) -> list[int]:
    #Note that heaps are lists of tuples in Python
    heap = []
    result = []
    
    for l in lists:
        #push the list on the heap with the priority being the first (min) item of the list
        heapq.heappush(heap, (l[0], l))

    #while the heap is not empty
    while heap:
        #get the smallest item from the top of the heap [0] is priority [1] is item.
        smallList = heapq.heappop(heap)[1]

        #if the heap isn't empty
        if heap:
            #compare the top of the heap priority to the first item in smallList
            while(smallList and smallList[0] < heap[0][0]):
                #as long as the top of heap has lower priority, pop and append items to the result
                result.append(smallList.pop(0))
            #if the smallList still isn't empty put it back on the heap
            if smallList:
                heapq.heappush(heap, (smallList[0], smallList))
        #if the heap is empty then put the rest of the smallList on the result
        else:
            result += smallList
    return result
