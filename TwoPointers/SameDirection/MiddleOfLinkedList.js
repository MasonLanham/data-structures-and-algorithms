"use strict";

class Node {
    constructor(val, next = null) {
        this.val = val;
        this.next = next;
    }
}

function middleOfLinkedList(head) {
    let slow = head;
    let fast = head.next;
    while(fast != null){
        slow = slow.next;
        fast = fast.next;
        if(fast != null){
            fast = fast.next;
        }
    }
    return slow.val;
}

function buildList(nodes, f) {
    const { value, done } = nodes.next();
    if (done) return null;
    const next = buildList(nodes, f);
    return new Node(f(value), next);
}

function splitWords(s) {
    return s === "" ? [] : s.split(" ");
}

function* main() {
    const head = buildList(splitWords(yield)[Symbol.iterator](), parseInt);
    const res = middleOfLinkedList(head);
    console.log(res);
}

class EOFError extends Error {}
{
    const gen = main();
    const next = (line) => gen.next(line).done && process.exit();
    let buf = "";
    next();
    process.stdin.setEncoding("utf8");
    process.stdin.on("data", (data) => {
        const lines = (buf + data).split("\n");
        buf = lines.pop();
        lines.forEach(next);
    });
    process.stdin.on("end", () => {
        buf && next(buf);
        gen.throw(new EOFError());
    });
}
