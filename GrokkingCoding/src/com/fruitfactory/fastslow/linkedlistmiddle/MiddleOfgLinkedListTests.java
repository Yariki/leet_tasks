package com.fruitfactory.fastslow.linkedlistmiddle;

import com.fruitfactory.fastslow.ListNode;
import org.junit.Test;
import static org.junit.Assert.*;

public class MiddleOfgLinkedListTests {

    @Test
    public void FirstTest(){
        ListNode head = prepareData();
        MiddleOfLinkedList middle = new MiddleOfLinkedList();
        ListNode mid = middle.findMiddle(head);

        assertEquals(3, mid.getValue());
    }

    @Test
    public void SecondTest(){
        ListNode head = prepareData2();
        MiddleOfLinkedList middle = new MiddleOfLinkedList();
        ListNode mid = middle.findMiddle(head);

        assertEquals(4, mid.getValue());
    }

    @Test
    public void ThirdTest(){
        ListNode head = prepareData3();
        MiddleOfLinkedList middle = new MiddleOfLinkedList();
        ListNode mid = middle.findMiddle(head);

        assertEquals(4, mid.getValue());
    }

    private ListNode prepareData(){
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);
        return head;
    }

    private ListNode prepareData2(){
        ListNode head = prepareData();
        head.next.next.next.next.next = new ListNode(6);
        return head;
    }

    private ListNode prepareData3(){
        ListNode head = prepareData2();
        head.next.next.next.next.next.next = new ListNode(7);
        return head;
    }


}
