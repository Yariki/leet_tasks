package com.fruitfactory.fastslow.cyclestart;

import com.fruitfactory.fastslow.ListNode;
import org.junit.Test;
import static org.junit.Assert.*;

public class CycleStartTest {

    @Test
    public void FirstTest(){
        ListNode  head = prepareList();
        head.next.next.next.next.next.next = head.next.next;
        CycleStart start = new CycleStart();
        ListNode result = start.findCycleStart(head);

        assertNotNull(result);
        assertEquals(3,result.getValue());
    }

    @Test
    public void SecondTest(){
        ListNode  head = prepareList();
        head.next.next.next.next.next.next = head.next;
        CycleStart start = new CycleStart();
        ListNode result = start.findCycleStart(head);

        assertNotNull(result);
        assertEquals(2,result.getValue());
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
