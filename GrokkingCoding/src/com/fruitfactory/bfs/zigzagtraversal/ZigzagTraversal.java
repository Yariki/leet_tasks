package com.fruitfactory.bfs.zigzagtraversal;

import com.fruitfactory.helpers.TreeNode;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

public class ZigzagTraversal {

    TreeNode _root;

    public ZigzagTraversal(TreeNode _root) {
        this._root = _root;
    }

    public List<List<Integer>> zigzagTraversal(){
        List<List<Integer>> result = new ArrayList<>();
        if(_root == null){
            return result;
        }

        boolean leftToRight = true;
        Queue<TreeNode> queue = new LinkedList<>();
        queue.offer(_root);

        while(!queue.isEmpty()){
            List<Integer> currentLevel = new LinkedList<>();
            int levelSize = queue.size();

            for (int i = 0; i < levelSize; i++) {
                TreeNode current = queue.poll();

                if(leftToRight)
                    currentLevel.add(current.value);
                else
                    currentLevel.add(0,current.value);

                if(current.left != null)
                    queue.offer(current.left);
                if (current.right != null)
                    queue.offer(current.right);
            }
            result.add(currentLevel);

            leftToRight = !leftToRight;
        }

        return result;
    }


}
