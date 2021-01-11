package com.fruitfactory.inplace.rotatelinkedlist;

import com.fruitfactory.inplace.base.ListNode;

public class RotateLinkedList {

    public ListNode rotate(ListNode head, int rotations){
        if(head == null || head.next == null || rotations <= 0)
            return head;

        ListNode lastNode = head;
        int listLength = 1;
        while (lastNode.next != null){
            lastNode = lastNode.next;
            listLength++;
        }

        lastNode.next = head;
        rotations %= listLength;
        int skiplength = listLength - rotations;
        ListNode lastNodeOfRotatedList = head;
        for (int i = 0; i < skiplength - 1; i++) {
            lastNodeOfRotatedList = lastNodeOfRotatedList.next;
        }

        head = lastNodeOfRotatedList.next;
        lastNodeOfRotatedList.next = null;
        return head;
    }

}
