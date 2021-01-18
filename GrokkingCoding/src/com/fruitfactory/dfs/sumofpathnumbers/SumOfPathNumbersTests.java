package com.fruitfactory.dfs.sumofpathnumbers;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;


public class SumOfPathNumbersTests {

    @Test
    public void FindSumOfAllPathNumbers_FirstAttempt_Success(){
        TreeNode root = prepareTree();
        SumOfPathNumbers spn = new SumOfPathNumbers(root);
        int result = spn.findSumOfPathNumbers();

        assertEquals(332, result);
    }

    @Test
    public void FindSumOfAllPathNumbers_SecondAttempt_Success(){
        TreeNode root = prepareTree();
        SumOfPathNumbers spn = new SumOfPathNumbers(root);
        int result = spn.findSumOfPathNumbers2();

        assertEquals(332, result);
    }

    private TreeNode prepareTree(){
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(0);
        root.right = new TreeNode(1);
        root.left.left = new TreeNode(1);
        root.right.left = new TreeNode(6);
        root.right.right = new TreeNode(5);
        return root;
    }

}
