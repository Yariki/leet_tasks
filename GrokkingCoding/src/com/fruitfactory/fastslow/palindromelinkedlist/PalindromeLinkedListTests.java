package com.fruitfactory.fastslow.palindromelinkedlist;

import com.fruitfactory.fastslow.ListNode;
import org.junit.Test;
import static org.junit.Assert.*;

public class PalindromeLinkedListTests {

    @Test
    public void FirstTest(){
        ListNode head = prepare();
        PalindromeLinkedList isPalindrome = new PalindromeLinkedList();
        boolean result = isPalindrome.isPalindrome(head);

        assertTrue(result);
    }

    @Test
    public void SecondTest(){
        ListNode head = prepare2();
        PalindromeLinkedList isPalindrome = new PalindromeLinkedList();
        boolean result = isPalindrome.isPalindrome(head);

        assertFalse(result);
    }

    private ListNode prepare(){
        ListNode head = new ListNode(2);
        head.next = new ListNode(4);
        head.next.next = new ListNode(6);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(2);
        return head;
    }

    private ListNode prepare2(){
        ListNode head = prepare();
        head.next.next.next.next.next = new ListNode(2);

        return head;
    }
}
