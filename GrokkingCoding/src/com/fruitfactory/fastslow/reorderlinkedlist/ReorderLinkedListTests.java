package com.fruitfactory.fastslow.reorderlinkedlist;

import com.fruitfactory.fastslow.ListNode;
import org.junit.Test;
import static org.junit.Assert.*;


public class ReorderLinkedListTests {

    @Test
    public void FirstTest(){
        ListNode head = buildLinkedList();
        ReorderLinkedList reorderLinkedList = new ReorderLinkedList();
        ListNode result = reorderLinkedList.reorder(head);

        checkLinkedLists(buildLinkedListResult(), result);
    }

    @Test
    public void SecondTest(){
        ListNode head = buildLinkedList2();
        ReorderLinkedList reorderLinkedList = new ReorderLinkedList();
        ListNode result = reorderLinkedList.reorder(head);

        checkLinkedLists(buildLinkedListResult2(), result);
    }

    private void checkLinkedLists(ListNode first, ListNode second){
        while(first != null && second != null){
            assertEquals(first.getValue(),second.getValue());
            first = first.next;
            second = second.next;
        }
    }

    private ListNode buildLinkedList(){
        ListNode head = new ListNode(2);
        head.next = new ListNode(4);
        head.next.next = new ListNode(6);
        head.next.next.next = new ListNode(8);
        head.next.next.next.next = new ListNode(10);
        head.next.next.next.next.next = new ListNode(12);
        return head;
    }


    private ListNode buildLinkedListResult(){
        ListNode head = new ListNode(2);
        head.next = new ListNode(12);
        head.next.next = new ListNode(4);
        head.next.next.next = new ListNode(10);
        head.next.next.next.next = new ListNode(6);
        head.next.next.next.next.next = new ListNode(8);
        return head;
    }

    private ListNode buildLinkedList2(){
        ListNode head = new ListNode(2);
        head.next = new ListNode(4);
        head.next.next = new ListNode(6);
        head.next.next.next = new ListNode(8);
        head.next.next.next.next = new ListNode(10);
        return head;
    }

    private ListNode buildLinkedListResult2(){
        ListNode head = new ListNode(2);
        head.next = new ListNode(10);
        head.next.next = new ListNode(4);
        head.next.next.next = new ListNode(8);
        head.next.next.next.next = new ListNode(6);
        return head;
    }




}
