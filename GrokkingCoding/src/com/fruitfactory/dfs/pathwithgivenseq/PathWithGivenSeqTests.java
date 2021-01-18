package com.fruitfactory.dfs.pathwithgivenseq;

import com.fruitfactory.helpers.TreeNode;

import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class PathWithGivenSeqTests {

    @Test
    public void FindpathWithSeq_FirstAttempt_NotFound_Success(){
        TreeNode root = prepareTree();
        PathWithGivenSeq pwgs = new PathWithGivenSeq(root, new int[]{1,0,7});
        boolean result = pwgs.findPath();

        assertFalse(result);
    }

    @Test
    public void FindpathWithSeq_FirstAttempt_Found_Success(){
        TreeNode root = prepareTree();
        PathWithGivenSeq pwgs = new PathWithGivenSeq(root, new int[]{1,1,6});
        boolean result = pwgs.findPath();

        assertTrue(result);
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
