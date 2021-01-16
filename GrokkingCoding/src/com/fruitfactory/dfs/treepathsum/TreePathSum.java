package com.fruitfactory.dfs.treepathsum;

import com.fruitfactory.helpers.TreeNode;

public class TreePathSum {

    private TreeNode root;
    private int sum;


    public TreePathSum(TreeNode root,  int sum) {
        this.root = root;
        this.sum = sum;
    }


    public boolean hasPath(){
        return hasPath(root, sum);
    }


    private boolean hasPath(TreeNode root, int sum){
        if(root == null) return false;

        if(root.value == sum && root.IsLeaf() ) return true;

        return hasPath(root.left, sum -  root.value) || hasPath(root.right, sum - root.value);
    }
}
