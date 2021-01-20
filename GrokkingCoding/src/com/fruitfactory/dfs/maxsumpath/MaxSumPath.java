package com.fruitfactory.dfs.maxsumpath;

import com.fruitfactory.helpers.TreeNode;

public class MaxSumPath {

    private TreeNode root;
    private int maxSum;

    public MaxSumPath(TreeNode root) {
        this.root = root;
        maxSum = Integer.MIN_VALUE;
    }

    public int getMaxSumPath(){
        findMaxSumPath(root);
        return maxSum;
    }

    private int findMaxSumPath(TreeNode current){
        if(current == null) return 0;

        int leftSum = findMaxSumPath(current.left);
        int rightSum = findMaxSumPath(current.right);

        leftSum = Math.max(leftSum, 0);
        rightSum = Math.max(rightSum,0);

        int currentSum = leftSum + rightSum + current.value;

        maxSum = Math.max(currentSum, maxSum);

        return Math.max(leftSum, rightSum) + current.value;
    }



}
