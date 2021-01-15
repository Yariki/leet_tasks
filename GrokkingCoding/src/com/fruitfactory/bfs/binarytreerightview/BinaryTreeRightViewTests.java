package com.fruitfactory.bfs.binarytreerightview;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;

import static org.junit.Assert.*;

public class BinaryTreeRightViewTests {

    @Test
    public void RightView_RootNull_Success(){
        BinaryTreeRightView rv =new BinaryTreeRightView(null);
        Integer[] result = rv.getRightView();

        assertNull(result);
    }

    @Test
    public void RightView_Root_Success(){
        TreeNode root = prepareTree();
        BinaryTreeRightView rv = new BinaryTreeRightView(root);
        Integer[] result = rv.getRightView();

        assertNotNull(result);
        assertArrayEquals(new Integer[] {12,1,5,3}, result);
    }


    private TreeNode prepareTree(){
        TreeNode root = new TreeNode(12);
        root.left = new TreeNode(7);
        root.right = new TreeNode(1);
        root.left.left = new TreeNode(9);
        root.right.left = new TreeNode(10);
        root.right.right = new TreeNode(5);
        root.left.left.left = new TreeNode(3);
        return root;
    }

}
