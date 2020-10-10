package com.fruitfactory.fastslow.reorderlinkedlist;

import com.fruitfactory.fastslow.*;

public class ReorderLinkedList {


    public ListNode reorder(ListNode head){
        ListNode fast = head, slow = head;
        
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        //reorder

        ListNode headHalf = slow;
        ListNode prev = null;
        while(headHalf !=  null){
            ListNode next = headHalf.next;
            headHalf.next = prev;
            prev = headHalf;
            headHalf = next;
        }

        headHalf = prev;
        ListNode first = head;

        while(headHalf != null){
            ListNode next1 = first.next;
            ListNode next2 = headHalf.next;
            first.next = headHalf;
            headHalf.next = next1;
            first = next1;
            headHalf = next2;
        }
        if(first != null){
            first.next = headHalf;
        }
        return head;
    }

}
