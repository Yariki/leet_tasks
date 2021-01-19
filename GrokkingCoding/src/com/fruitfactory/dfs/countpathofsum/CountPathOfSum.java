package com.fruitfactory.dfs.countpathofsum;

import com.fruitfactory.helpers.TreeNode;

import java.util.ListIterator;
import java.util.Stack;

public class CountPathOfSum {

    private TreeNode root;
    private int s;

    public CountPathOfSum(TreeNode root, int s) {
        this.root = root;
        this.s = s;
    }

    public int findCountPathOfSum(){
        Stack<Integer> currentPath = new Stack<>();
        return findCountPathOfSum(root, currentPath);
    }

    private int findCountPathOfSum(TreeNode current, Stack<Integer> currentPath){
        if(current == null) return 0;

        currentPath.push(current.value);

        int pathCount = 0, pathSum = 0;
        ListIterator<Integer> iterator = currentPath.listIterator(currentPath.size());

        while(iterator.hasPrevious()){
            int val = iterator.previous();
            pathSum += val;
            if(pathSum == s) pathCount++;
        }

        pathCount += findCountPathOfSum(current.left, currentPath);

         pathCount += findCountPathOfSum(current.right, currentPath);

        currentPath.pop();

        return pathCount;
    }

}
