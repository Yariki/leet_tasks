package com.fruitfactory.inplace.reverseksublist;

import com.fruitfactory.inplace.base.ListNode;

public class ReverseKSublist {

    public ListNode reverse(ListNode head, int k){
        if(k <= 1 || head == null){
            return head;
        }

        ListNode current = head, previous = null;
        while(true){
            ListNode lastNodeOfPreviousPart= previous;
            ListNode lastNodeOFSublist = current;
            ListNode next = null;
            for (int i = 0; current != null && i < k ; i++) {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            if(lastNodeOfPreviousPart != null){
                lastNodeOfPreviousPart.next = previous;
            }else{
                head = previous;
            }

            lastNodeOFSublist.next = current;
            if(current == null)
                break;

            previous = lastNodeOFSublist;
        }

        return head;
    }

}
