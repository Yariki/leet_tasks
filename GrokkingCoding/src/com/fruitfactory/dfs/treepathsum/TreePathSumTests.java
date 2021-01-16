package com.fruitfactory.dfs.treepathsum;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;

import static org.junit.Assert.*;


public class TreePathSumTests {

    @Test
    public void PathSum_FirstAttempt_Success(){
        TreeNode root = prepareTree();
        TreePathSum tps = new TreePathSum(root, 23);
        boolean result = tps.hasPath();

        assertTrue(result);
    }

    @Test
    public void PathSum_SecondAttempt_Success(){
        TreeNode root = prepareTree();
        TreePathSum tps = new TreePathSum(root, 16);
        boolean result = tps.hasPath();

        assertFalse(result);
    }

    private TreeNode prepareTree(){
        TreeNode root = new TreeNode(12);
        root.left = new TreeNode(7);
        root.right = new TreeNode(1);
        root.left.left = new TreeNode(9);
        root.right.left = new TreeNode(10);
        root.right.right = new TreeNode(5);

        return root;
    }

}
