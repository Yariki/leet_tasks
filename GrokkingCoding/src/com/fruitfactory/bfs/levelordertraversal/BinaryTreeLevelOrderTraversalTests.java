package com.fruitfactory.bfs.levelordertraversal;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;


import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotNull;


import java.util.List;

public class BinaryTreeLevelOrderTraversalTests {

    @Test
    public void LevelOrderTraversalTest(){
        TreeNode root = prepareTree();
        BinaryTreeLevelOrderTraversal traversal = new BinaryTreeLevelOrderTraversal();
        List<List<Integer>> result = traversal.traverseLevelOrder(root);

        assertNotNull(result);

        assertEquals(12, (int)result.get(0).get(0));

        assertEquals(7, (int)result.get(1).get(0));
        assertEquals(1, (int)result.get(1).get(1));

        assertEquals(9, (int)result.get(2).get(0));
        assertEquals(10, (int)result.get(2).get(1));
        assertEquals(5, (int)result.get(2).get(2));
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
