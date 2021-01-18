package com.fruitfactory.dfs.allpathsum;

import com.fruitfactory.helpers.TreeNode;

import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class AllPathSumTests {


    @Test
    public void FindAllPath_FirstAttempt_Success(){
        TreeNode root = prepareTree();
        AllPathSum aps = new AllPathSum(root,23);
        List<List<Integer>> result = aps.findAllPath();

        assertNotNull(result);
        assertEquals(2, result.size());

        assertEquals(3, result.get(0).size());
        assertEquals(12, (int)result.get(0).get(0));
        assertEquals(7, (int)result.get(0).get(1));
        assertEquals(4, (int)result.get(0).get(2));


        assertEquals(3, result.get(1).size());
        assertEquals(12, (int)result.get(1).get(0));
        assertEquals(1, (int)result.get(1).get(1));
        assertEquals(10, (int)result.get(1).get(2));
    }


    private TreeNode prepareTree(){
        TreeNode root = new TreeNode(12);
        root.left = new TreeNode(7);
        root.right = new TreeNode(1);
        root.left.left = new TreeNode(4);
        root.right.left = new TreeNode(10);
        root.right.right = new TreeNode(5);
        return root;
    }

}
