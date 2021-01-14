package com.fruitfactory.bfs.connectalllevelordersiblings;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;

import static org.junit.Assert.*;

public class ConnectAllLevelOrderSiblingsTests {

    @Test
    public void ConnectAllLevels_Success(){
        TreeNode root = prepareTree();
        ConnectAllLevelOrderSiblings calos = new ConnectAllLevelOrderSiblings(root);
        calos.connectAllLevels();

        assertNotNull(root);
        assertEquals(12,root.value);
        assertEquals(7,root.next.value);
        assertEquals(1,root.next.next.value);
        assertEquals(9,root.next.next.next.value);
        assertEquals(10,root.next.next.next.next.value);
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
