package com.fruitfactory.inplace.reversesublist;

import com.fruitfactory.inplace.base.ListNode;

public class ReverseSubList {

    public ListNode reverseSubList(ListNode head, int p, int q){
        if(p == q) return head;

        ListNode current = head, previous = null;

        for (int i = 0; i < p - 1 && current != null; i++) {
            previous = current;
            current = current.next;
        }
        ListNode lastNodeOnFirstPart = previous;
        ListNode lastNodeOfSubList = current;
        ListNode next = null;

        for (int i = 0; i < q - p + 1 && current != null; i++) {
            next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        if(lastNodeOnFirstPart != null){
            lastNodeOnFirstPart.next = previous;
        } else{
            head = previous;
        }

        lastNodeOfSubList.next = current;

        return head;
    }

}
