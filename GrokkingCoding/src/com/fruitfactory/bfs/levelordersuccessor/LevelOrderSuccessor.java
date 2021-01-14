package com.fruitfactory.bfs.levelordersuccessor;

import com.fruitfactory.helpers.TreeNode;
import com.sun.source.tree.Tree;

import java.util.LinkedList;
import java.util.Queue;

public class LevelOrderSuccessor {

    private TreeNode root;
    private int key;

    public LevelOrderSuccessor(TreeNode root, int key) {
        this.root = root;
        this.key = key;
    }

    public TreeNode getLevelOrderSuccessor(){
        if(root == null) return null;

        Queue<TreeNode> queue = new LinkedList<>();
        queue.offer(root);

        while(!queue.isEmpty()){

            TreeNode current = queue.poll();

            if(current.left != null) queue.offer(current.left);
            if(current.right != null) queue.offer(current.right);
            if(current.value == key)
                break;

        }
        return queue.peek();
    }

}
