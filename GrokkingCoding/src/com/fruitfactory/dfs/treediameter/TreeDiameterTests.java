package com.fruitfactory.dfs.treediameter;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class TreeDiameterTests {


    @Test
    public void TreeDiameter_FirstAttempt_Success(){
        TreeNode root = prepareTree1();
        TreeDiameter td = new TreeDiameter(root);
        int result = td.getTreeDiameter();

        assertEquals(5, result);
    }

    @Test
    public void TreeDiameter_SecondAttempt_Success(){
        TreeNode root = prepareTree2();
        TreeDiameter td = new TreeDiameter(root);
        int result = td.getTreeDiameter();

        assertEquals(7, result);
    }

    private TreeNode prepareTree1(){
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.right.left = new TreeNode(5);
        root.right.right = new TreeNode(6);
        return root;
    }

    private TreeNode prepareTree2(){
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.right.left = new TreeNode(5);
        root.right.right = new TreeNode(6);
        root.left.left = null;
        root.right.left.left = new TreeNode(7);
        root.right.left.right = new TreeNode(8);
        root.right.right.left = new TreeNode(9);
        root.right.left.right.left = new TreeNode(10);
        root.right.right.left.left = new TreeNode(11);
        return root;
    }

}
