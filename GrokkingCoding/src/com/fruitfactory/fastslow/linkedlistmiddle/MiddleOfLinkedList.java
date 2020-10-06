package com.fruitfactory.fastslow.linkedlistmiddle;

import com.fruitfactory.fastslow.ListNode;

public class MiddleOfLinkedList {

    public ListNode findMiddle(ListNode head) {
        ListNode slow = head, fast = head;

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

}
