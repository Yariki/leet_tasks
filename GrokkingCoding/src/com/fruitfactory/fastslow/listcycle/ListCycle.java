package com.fruitfactory.fastslow.listcycle;

import com.fruitfactory.fastslow.ListNode;

public class ListCycle {

    public boolean hasCycle(ListNode node){
        ListNode slow = node;
        ListNode fast = node;

        while(fast  != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
            if(slow == fast) return true;
        }
        return false;
    }

    public int findCycleLenght(ListNode head){
        ListNode slow = head;
        ListNode fast = head;

        while(fast  != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
            if(slow == fast) return calculateLenght(slow);
        }
        return 0;
    }

    private int calculateLenght(ListNode slow){
        ListNode node = slow;
        int length = 0;

        do{
            node = node.next;
            length++;
        }while(node != slow);

        return length;
    }



}
