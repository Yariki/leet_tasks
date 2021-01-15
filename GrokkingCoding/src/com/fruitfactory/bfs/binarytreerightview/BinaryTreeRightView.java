package com.fruitfactory.bfs.binarytreerightview;

import com.fruitfactory.helpers.TreeNode;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

public class BinaryTreeRightView {

    TreeNode root;

    public BinaryTreeRightView(TreeNode root) {
        this.root = root;
    }

    public Integer[] getRightView(){
        if(root == null) return null;

        List<Integer> result = new ArrayList<Integer>();
        Queue<TreeNode> queue = new LinkedList<>();
        queue.offer(root);

        while (!queue.isEmpty()){
            int levelSize = queue.size();

            for (int i = 0; i < levelSize; i++) {
                TreeNode current = queue.poll();
                if(i == levelSize - 1)
                    result.add(current.value);
                if(current.left != null)
                    queue.offer(current.left);
                if(current.right != null)
                    queue.offer(current.right);
            }
        }
        Integer[] arr = new Integer[result.size()];
        return result.toArray(arr);
    }

}
