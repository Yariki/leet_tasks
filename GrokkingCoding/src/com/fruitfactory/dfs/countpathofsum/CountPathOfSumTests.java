package com.fruitfactory.dfs.countpathofsum;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;

import static org.junit.Assert.*;



public class CountPathOfSumTests {


    @Test
    public void CountPath_FirstAttempt_Success(){
        TreeNode root = prepareTree1();
        CountPathOfSum cps = new CountPathOfSum(root, 11);
        int result = cps.findCountPathOfSum();

        assertEquals(2, result);
    }

    @Test
    public void CountPath_SecondAttempt_Success(){
        TreeNode root = prepareTree2();
        CountPathOfSum cps = new CountPathOfSum(root, 12);
        int result = cps.findCountPathOfSum();

        assertEquals(3, result);
    }

    private TreeNode prepareTree1(){
        TreeNode root = new TreeNode(12);
        root.left = new TreeNode(7);
        root.right = new TreeNode(1);
        root.left.left = new TreeNode(4);
        root.right.left = new TreeNode(10);
        root.right.right = new TreeNode(5);

        return root;
    }

    private TreeNode prepareTree2(){
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(7);
        root.left.left = new TreeNode(6);
        root.left.right = new TreeNode(5);

        root.right = new TreeNode(9);
        root.right.left = new TreeNode(2);
        root.right.right = new TreeNode(3);

        return root;
    }


}
