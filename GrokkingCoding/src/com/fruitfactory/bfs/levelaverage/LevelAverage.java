package com.fruitfactory.bfs.levelaverage;

import com.fruitfactory.helpers.TreeNode;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

public class LevelAverage {

    TreeNode _root;

    public LevelAverage(TreeNode _root) {
        this._root = _root;
    }

    public List<Double>  findLevelAverages(){
        List<Double> result = new ArrayList<>();
        if(_root == null) return result;

        Queue<TreeNode> queue = new LinkedList<>();
        queue.offer(_root);

        while(!queue.isEmpty()){
            double sumOfLevel = 0.0;
            int levelSize = queue.size();

            for (int i = 0; i < levelSize; i++) {
                TreeNode current = queue.poll();
                sumOfLevel += (double) current.value;

                if(current.left != null)
                    queue.offer(current.left);
                if(current.right != null)
                    queue.offer(current.right);
            }

            result.add(roundAvoid(sumOfLevel/ (double)levelSize,1));
        }

        return result;
    }

    public static double roundAvoid(double value, int places) {
        double scale = Math.pow(10, places);
        return Math.round(value * scale) / scale;
    }


}
