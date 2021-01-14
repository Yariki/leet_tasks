package com.fruitfactory.bfs.levelordersuccessor;

import com.fruitfactory.helpers.TreeNode;
import com.sun.source.tree.Tree;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class LevelOrderSuccessorTests {

    @Test
    public void LevelOrderSuccessor_RootNull_ReturnNullSuccess()
    {
        LevelOrderSuccessor los = new LevelOrderSuccessor(null, 1);
        TreeNode result = los.getLevelOrderSuccessor();

        assertNull(result);
    }

    @Test
    public void LevelOrderSuccessor_FirstTry_ReturnTreeNodeSuccess()
    {
        TreeNode root = prepareTree();
        LevelOrderSuccessor los = new LevelOrderSuccessor(root, 12);
        TreeNode result = los.getLevelOrderSuccessor();

        assertNotNull(result);
        assertEquals(7, result.value);
    }

    @Test
    public void LevelOrderSuccessor_SecondTry_ReturnTreeNodeSuccess()
    {
        TreeNode root = prepareTree();
        LevelOrderSuccessor los = new LevelOrderSuccessor(root, 9);
        TreeNode result = los.getLevelOrderSuccessor();

        assertNotNull(result);
        assertEquals(10, result.value);
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
