package com.fruitfactory.bfs.zigzagtraversal;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class ZigzagTraversalTests {


    @Test
    public void ZigzagTraversalTest(){
        TreeNode root = prepareTree();
        ZigzagTraversal zt = new ZigzagTraversal(root);
        List<List<Integer>> result = zt.zigzagTraversal();

        assertNotNull(result);
        assertTrue(result.size() > 0);

        assertEquals(12, (int)result.get(0).get(0));

        assertEquals(1, (int)result.get(1).get(0));
        assertEquals(7, (int)result.get(1).get(1));

        assertEquals(9, (int)result.get(2).get(0));
        assertEquals(10, (int)result.get(2).get(1));
        assertEquals(5, (int)result.get(2).get(2));

        assertEquals(17, (int)result.get(3).get(0));
        assertEquals(20, (int)result.get(3).get(1));
    }


    private TreeNode prepareTree(){
        TreeNode root = new TreeNode(12);
        root.left = new TreeNode(7);
        root.right = new TreeNode(1);
        root.left.left = new TreeNode(9);
        root.right.left = new TreeNode(10);
        root.right.right = new TreeNode(5);
        root.right.left.left = new TreeNode(20);
        root.right.left.right = new TreeNode(17);

        return root;
    }

}
