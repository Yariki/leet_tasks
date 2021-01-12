package com.fruitfactory.bfs.levelordertraversal;

import com.fruitfactory.helpers.TreeNode;

import java.util.*;

public class BinaryTreeLevelOrderTraversal {

    public List<List<Integer>> traverseLevelOrder(TreeNode root){
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        if(root == null){
            return result;
        }
        Queue<TreeNode> queue = new LinkedList<>();
        queue.offer(root);

        while(!queue.isEmpty()){
            List<Integer> level = new ArrayList<>();
            int levelSize = queue.size();
            for (int i = 0; i < levelSize;i++) {
                TreeNode current = queue.poll();
                if(current.left  != null)
                    queue.offer(current.left);
                if(current.right != null)
                    queue.offer(current.right);
                level.add(current.value);
            }
            if(!level.isEmpty())
                result.add(level);
        }
        return result;
    }
}
