package com.fruitfactory.dfs.maxsumpath;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;

import static org.junit.Assert.*;

public class MaxSumPathTests {

    @Test
    public void MaxPathSun_FirstAttempt_Success(){
        TreeNode root = prepareTree1();
        MaxSumPath msp  = new MaxSumPath(root);
        int result = msp.getMaxSumPath();

        assertEquals(6, result);
    }

    @Test
    public void MaxPathSun_SecondAttempt_Success(){
        TreeNode root = prepareTree2();
        MaxSumPath msp  = new MaxSumPath(root);
        int result = msp.getMaxSumPath();

        assertEquals(31, result);
    }

    @Test
    public void MaxPathSun_ThirdAttempt_Success(){
        TreeNode root = prepareTree3();
        MaxSumPath msp  = new MaxSumPath(root);
        int result = msp.getMaxSumPath();

        assertEquals(-1, result);
    }

    private TreeNode prepareTree1(){
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        return root;
    }

    private TreeNode prepareTree2(){
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(1);
        root.left.right = new TreeNode(3);
        root.right.left = new TreeNode(5);
        root.right.right = new TreeNode(6);
        root.right.left.left = new TreeNode(7);
        root.right.left.right = new TreeNode(8);
        root.right.right.left = new TreeNode(9);
        return root;
    }

    private TreeNode prepareTree3(){
        TreeNode root = new TreeNode(-1);
        root.left = new TreeNode(-3);

        return root;
    }


}
