package com.fruitfactory.bfs.connectlevelordersiblings;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;

import static org.junit.Assert.*;

public class ConnectLevelOrderSiblingsTests {

    @Test
    public void LinkLevelNodes_Success(){
        TreeNode root = prepareTree();
        ConnectLevelOrderSiblings clos  = new ConnectLevelOrderSiblings(root);
        clos.connectLevels();

        assertNull(root.next);
        assertEquals(root.left.next, root.right);
        assertNull(root.right.next);

        assertEquals(root.left.left.next, root.right.left);
        assertEquals(root.right.left.next, root.right.right);
        assertNull(root.right.right.next);
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
