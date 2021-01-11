package com.fruitfactory.inplace.rotatelinkedlist;

import com.fruitfactory.inplace.base.ListNode;
import org.junit.Test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotNull;

public class RotateLinkedListTests {

    @Test
    public void RotateLisnkedListTest(){
        ListNode head = prepareList();
        RotateLinkedList rt = new RotateLinkedList();
        head = rt.rotate(head,3);

        assertNotNull(head);
        assertEquals(4, head.value);
        assertEquals(5, head.next.value);
        assertEquals(6, head.next.next.value);
        assertEquals(1, head.next.next.next.value);
    }



    private ListNode prepareList(){
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);
        head.next.next.next.next.next = new ListNode(6);

        return head;
    }

}
