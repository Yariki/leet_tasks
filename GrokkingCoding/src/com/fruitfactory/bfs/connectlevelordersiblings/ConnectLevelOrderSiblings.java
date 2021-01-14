package com.fruitfactory.bfs.connectlevelordersiblings;

import com.fruitfactory.helpers.TreeNode;

import java.util.LinkedList;
import java.util.Queue;

public class ConnectLevelOrderSiblings {

    private TreeNode root;

    public ConnectLevelOrderSiblings(TreeNode root) {
        this.root = root;
    }


    public void connectLevels(){
        if(root == null) return;

        Queue<TreeNode> queue = new LinkedList<>();
        queue.offer(root);

        while (!queue.isEmpty()){

            int levelSize = queue.size();
            TreeNode previous = null;

            for (int i = 0; i < levelSize; i++) {
                TreeNode current = queue.poll();

                if(previous != null)
                    previous.next = current;
                previous = current;

                if(current.left != null) queue.offer(current.left);
                if(current.right != null) queue.offer(current.right);
            }
        }
    }

}
