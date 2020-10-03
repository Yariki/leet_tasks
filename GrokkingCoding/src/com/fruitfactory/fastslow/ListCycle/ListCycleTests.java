package com.fruitfactory.fastslow.ListCycle;

import com.fruitfactory.fastslow.ListNode;
import org.junit.Test;
import static org.junit.Assert.*;

public class ListCycleTests {

    @Test
    public void  FirstTest(){
        ListNode head = prepareList();

        ListCycle cycle = new ListCycle();
        boolean result = cycle.hasCycle(head);

        assertFalse(result);
    }


    @Test
    public void  SecondTest(){
        ListNode head = prepareList();
        head.next.next.next.next.next.next = head.next.next;

        ListCycle cycle = new ListCycle();
        boolean result = cycle.hasCycle(head);

        assertTrue(result);
    }

    @Test
    public void ThirdTest(){
        ListNode head = prepareList();
        head.next.next.next.next.next.next = head.next.next;

        ListCycle cycle = new ListCycle();
        int length = cycle.findCycleLenght(head);

        assertEquals(4, length);
    }

    @Test
    public void FourtTest(){
        ListNode head = prepareList();

        ListCycle cycle = new ListCycle();
        int length = cycle.findCycleLenght(head);

        assertEquals(0, length);
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
