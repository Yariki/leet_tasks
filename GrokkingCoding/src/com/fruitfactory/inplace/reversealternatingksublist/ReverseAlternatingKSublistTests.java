package com.fruitfactory.inplace.reversealternatingksublist;

import com.fruitfactory.inplace.base.ListNode;
import com.fruitfactory.inplace.reverseksublist.ReverseKSublist;
import org.junit.Test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotNull;

public class ReverseAlternatingKSublistTests {

    @Test
    public void FirstTest(){
        ListNode head = prepareList();
        ReverseAlternatingKSublist rks = new ReverseAlternatingKSublist();

        ListNode result = rks.reverse(head, 2);

        assertNotNull(result);
        assertEquals(2,result.value);
        assertEquals(1,result.next.value);
        assertEquals(3,result.next.next.value);
        assertEquals(4,result.next.next.next.value);
        assertEquals(6,result.next.next.next.next.value);
    }

    private ListNode prepareList(){
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);
        head.next.next.next.next.next = new ListNode(6);
        head.next.next.next.next.next.next = new ListNode(7);
        head.next.next.next.next.next.next.next = new ListNode(8);

        return head;
    }

}
