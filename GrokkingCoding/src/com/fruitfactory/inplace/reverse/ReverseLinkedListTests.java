package com.fruitfactory.inplace.reverse;

import com.fruitfactory.inplace.base.ListNode;
import org.junit.Test;
import static org.junit.Assert.*;

public class ReverseLinkedListTests {

    @Test
    public void FirstTest(){
        ListNode head = prepareFirstLinkedList();
        ReverseLinkedList rll = new ReverseLinkedList();
        ListNode result = rll.reverseList(head);

        assertNotNull(result);
        assertEquals(10, result.value);
    }

    private ListNode prepareFirstLinkedList(){
        ListNode head = new ListNode(2);
        head.next = new ListNode(4);
        head.next.next = new ListNode(6);
        head.next.next.next = new ListNode(8);
        head.next.next.next.next = new ListNode(10);
        return head;
    }


}
