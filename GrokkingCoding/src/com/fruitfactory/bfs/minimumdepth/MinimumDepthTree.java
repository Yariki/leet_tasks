package com.fruitfactory.bfs.minimumdepth;

import com.fruitfactory.helpers.TreeNode;

import java.util.LinkedList;
import java.util.Queue;

public class MinimumDepthTree {

    private TreeNode root;

    public MinimumDepthTree(TreeNode root) {
        this.root = root;
    }

    public int findDepth(){
        if(root == null) return -1;

        int  minDepth = -1;

        Queue<TreeNode> queue = new LinkedList<>();
        queue.offer(root);
        int currentDepth = 0;
        while(!queue.isEmpty()){
            int levelSize = queue.size();
            currentDepth++;
            for (int i = 0; i < levelSize; i++) {
                TreeNode current = queue.poll();

                if(current.IsLeaf() && minDepth == -1)
                    minDepth = currentDepth;
                else if (current.IsLeaf())
                    minDepth = Math.min(minDepth, currentDepth);

                if(current.left != null) queue.offer(current.left);
                if(current.right != null) queue.offer(current.right);
            }
        }
        return minDepth;
    }

}
