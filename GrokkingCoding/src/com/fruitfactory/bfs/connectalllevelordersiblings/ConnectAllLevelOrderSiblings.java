package com.fruitfactory.bfs.connectalllevelordersiblings;

import com.fruitfactory.helpers.TreeNode;
import com.sun.source.tree.Tree;

import java.util.LinkedList;
import java.util.Queue;

public class ConnectAllLevelOrderSiblings {

    private TreeNode root;

    public ConnectAllLevelOrderSiblings(TreeNode root) {
        this.root = root;
    }

    public void connectAllLevels(){
        if(root == null) return;

        Queue<TreeNode> queue = new LinkedList<>();
        queue.offer(root);
        TreeNode previous = null;

        while (!queue.isEmpty()){

            TreeNode current = queue.poll();

            if(previous != null)
                previous.next = current;
            previous = current;

            if(current.left != null)
                queue.offer(current.left);
            if (current.right != null)
                queue.offer(current.right);
        }
    }
}
