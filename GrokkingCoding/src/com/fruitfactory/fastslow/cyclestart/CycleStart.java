package com.fruitfactory.fastslow.cyclestart;

import com.fruitfactory.fastslow.ListNode;

public class CycleStart {

    public ListNode findCycleStart(ListNode head){
        ListNode slow = head;
        ListNode fast = head;
        int length = 0;

        while (fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
            if(slow == fast){
                length = calculateLength(slow);
                break;
            }
        }

        return findStart(head, length);
    }

    private int calculateLength(ListNode slow){
        ListNode node = slow;
        int length = 0;

        do{
            node = node.next;
            length++;
        }while(node != slow);

        return length;
    }

    private ListNode findStart(ListNode head, int length){
        ListNode pt1 = head;
        ListNode pt2 = head;
        int count = length;

        while (count > 0){
            pt2 = pt2.next;
            count--;
        }

        while (pt1 != pt2){
            pt1 = pt1.next;
            pt2 = pt2.next;
        }
        return pt1;
    }
}
