package com.fruitfactory.dfs.treediameter;

import com.fruitfactory.helpers.TreeNode;

public class TreeDiameter {

    private int treeDiameter = 0;

    private TreeNode root;

    public TreeDiameter(TreeNode root) {
        this.root = root;
    }


    public int getTreeDiameter(){
        calculateTreeDiameter(root);
        return treeDiameter;
    }

    private int calculateTreeDiameter(TreeNode current){
        if(current ==  null) return 0;

        int leftHeight = calculateTreeDiameter(current.left);
        int rightHeight  = calculateTreeDiameter(current.right);

        int diameter = leftHeight + rightHeight + 1;
        treeDiameter = Math.max(treeDiameter, diameter);

        return Math.max(leftHeight, rightHeight) + 1;
    }


}
