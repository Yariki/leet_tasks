package com.fruitfactory.bfs.reverselevelordertraversal;

import com.fruitfactory.helpers.TreeNode;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

public class ReversalLevelOrderTraversal {


    public List<List<Integer>> reverseTraversal(TreeNode root){
        List<List<Integer>> result = new LinkedList<List<Integer>>();
        if(root == null)
            return result;

        Queue<TreeNode> queue = new LinkedList<TreeNode>();

        queue.offer(root);

        while (!queue.isEmpty()){
            int levelSize = queue.size();
            List<Integer> level = new ArrayList<>();

            for (int i = 0; i < levelSize; i++) {
                TreeNode current = queue.poll();
                if(current.left != null) queue.offer(current.left);
                if(current.right != null) queue.offer(current.right);
                level.add(current.value);
            }
            if(!level.isEmpty())
                result.add(0,level);
        }
        return result;
    }

}
