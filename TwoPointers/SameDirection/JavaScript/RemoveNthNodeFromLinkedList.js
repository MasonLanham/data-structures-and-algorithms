/*Given the head of a linked list and an integer n, remove the n-th node from the end of the list and return the head of the modified list.

Input:

head: the head node of a singly linked list
n: an integer representing the position from the end (1-indexed)
Output:

Return the head of the modified linked list
Constraints:

The list has at least 1 node
n is a valid position from the end (1 <= n <= length of list)
Examples:

Example 1:

Input: head = [1, 2, 3, 4], n = 1
Output: [1, 2, 3]
Explanation: Remove the 1st node from the end (value 4)
Example 2:

Input: head = [1, 2, 3, 4], n = 2
Output: [1, 2, 4]
Explanation: Remove the 2nd node from the end (value 3)
Example 3:

Input: head = [1, 2, 3, 4], n = 4
Output: [2, 3, 4]
Explanation: Remove the 4th node from the end (the head, value 1)*/

function removeNthFromEnd(head, n) {
    let slow = head;
    let fast = head;
    //moving fast n steps ahead
    for(let i = 0; i < n; i++){
        fast = fast.next;
    }
    
    //moving both pointers until fast is at the end of the list
    if(fast != null){
        while(fast.next != null){
            slow = slow.next;
            fast = fast.next;
        }
    }

    //case slow is pointing to head
    if(slow === head){
        return slow.next;
    }
    else{
        slow.next = slow.next.next;
    }
    return head;
}
