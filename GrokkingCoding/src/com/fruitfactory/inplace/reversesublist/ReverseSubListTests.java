package com.fruitfactory.inplace.reversesublist;

import com.fruitfactory.inplace.base.ListNode;
import org.junit.Test;
import static org.junit.Assert.*;

public class ReverseSubListTests {


    @Test
    public void FirstTest(){
        ListNode head = prepareList();
        ReverseSubList rsl = new ReverseSubList();
        ListNode result = rsl.reverseSubList(head,2,4);

        assertEquals(1,result.value);
        assertEquals(4,result.next.value);
        assertEquals(3,result.next.next.value);
        assertEquals(2,result.next.next.next.value);
        assertEquals(5,result.next.next.next.next.value);

    }

    private ListNode prepareList(){
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);

        return head;
    }

}
