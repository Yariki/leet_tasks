package com.fruitfactory.bfs.reverselevelordertraversal;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;


import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotNull;
import java.util.List;

public class ReversalLevelOrderTraversalTests {


    @Test
    public void ReverseLevelOrderTraverseTests(){
        TreeNode root = prepareTree();
        ReversalLevelOrderTraversal reversalLevelOrderTraversal = new ReversalLevelOrderTraversal();
        List<List<Integer>> result = reversalLevelOrderTraversal.reverseTraversal(root);


        assertNotNull(result);

        assertEquals(9, (int)result.get(0).get(0));
        assertEquals(10, (int)result.get(0).get(1));
        assertEquals(5, (int)result.get(0).get(2));

        assertEquals(7, (int)result.get(1).get(0));
        assertEquals(1, (int)result.get(1).get(1));

        assertEquals(12, (int)result.get(2).get(0));
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
