package com.fruitfactory.helpers;

public class TreeNode {
    public int value;
    public TreeNode left;
    public TreeNode right;
    public TreeNode next;

    public TreeNode(int value) {
        this.value = value;
        left = right = next = null;
    }

    public boolean IsLeaf(){
        return left == null && right == null;
    }

}
