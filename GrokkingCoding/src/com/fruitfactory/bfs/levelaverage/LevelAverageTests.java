package com.fruitfactory.bfs.levelaverage;

import com.fruitfactory.helpers.TreeNode;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class LevelAverageTests {

    @Test
    public void LevelAverageTest(){
        TreeNode root = prepareTree();
        LevelAverage la = new LevelAverage(root);
        List<Double> result = la.findLevelAverages();

        assertNotNull(result);
        assertTrue(result.size() > 0);

        assertEquals(12.0, (double)result.get(0),0.0);
        assertEquals(4.0, (double)result.get(1),0.0);
        assertEquals(6.5, (double)result.get(2),0.0);
    }


    private TreeNode prepareTree(){
        TreeNode root = new TreeNode(12);
        root.left = new TreeNode(7);
        root.right = new TreeNode(1);
        root.left.left = new TreeNode(9);
        root.left.right = new TreeNode(2);
        root.right.left = new TreeNode(10);
        root.right.right = new TreeNode(5);
        return root;
    }

}
