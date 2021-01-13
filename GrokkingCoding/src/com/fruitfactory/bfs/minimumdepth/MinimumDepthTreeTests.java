package com.fruitfactory.bfs.minimumdepth;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class MinimumDepthTreeTests {

    @Test
    public void MinimumDepthRootNullTest(){
        MinimumDepthTree ml = new MinimumDepthTree(null);
        int result = ml.findDepth();

        assertEquals(-1, result);
    }

    @Test
    public void MinimumDepthRootNotNullTest(){

        TreeNode root = prepareTree();
        MinimumDepthTree ml = new MinimumDepthTree(root);
        int result = ml.findDepth();

        assertEquals(2, result);
    }

    private TreeNode prepareTree(){
        TreeNode root = new TreeNode(12);
        root.left = new TreeNode(7);
        root.right = new TreeNode(1);
        root.right.left = new TreeNode(10);
        root.right.right = new TreeNode(5);

        return root;
    }

}
