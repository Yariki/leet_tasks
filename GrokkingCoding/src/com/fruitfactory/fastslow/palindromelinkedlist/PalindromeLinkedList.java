package com.fruitfactory.fastslow.palindromelinkedlist;

import com.fruitfactory.fastslow.*;

import java.awt.*;

public class PalindromeLinkedList {

    public boolean isPalindrome(ListNode head){
        if(head == null || head.next == null){
            return true;
        }
        ListNode slow = head, fast = head;
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode headSecondHalf = reverse(slow);
        ListNode copeHead = headSecondHalf;

        while(head != null && headSecondHalf != null){
            if(head.getValue() != headSecondHalf.getValue()){
                break;
            }
            head = head.next;
            headSecondHalf = headSecondHalf.next;
        }
        reverse(copeHead);
        if(head == null || headSecondHalf == null){
            return true;
        }

        return false;
    }

    private ListNode reverse(ListNode head){
        ListNode prev = null;
        while (head != null){
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }

        return prev;
    }

}
