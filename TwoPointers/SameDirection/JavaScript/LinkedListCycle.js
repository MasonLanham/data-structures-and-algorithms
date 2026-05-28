/*
Given a linked list with potentially a loop, determine whether the linked list from the first node contains a cycle in it. For bonus points, do this with constant space.

Parameters
nodes: The first node of a linked list with potentially a loop.
Result
Whether there is a loop contained in the linked list.
*/

class Node {
    constructor(val, next = null) {
        this.val = val;
        this.next = next;
    }
}

function hasCycle(nodes) {
    let fast = nodes.next;
    let slow = nodes;
    while(fast != null && fast.next != null){
        if(fast === slow){
            return true;
        }
        else{
            fast = fast.next.next;
            slow = slow.next;
        }
    }
    return false;
}
