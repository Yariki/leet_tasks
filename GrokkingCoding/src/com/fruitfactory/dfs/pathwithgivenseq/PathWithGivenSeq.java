package com.fruitfactory.dfs.pathwithgivenseq;

import com.fruitfactory.helpers.TreeNode;

public class PathWithGivenSeq {

    private TreeNode root;
    private int[] sequence;

    public PathWithGivenSeq(TreeNode root, int[] sequence) {
        this.root = root;
        this.sequence = sequence;
    }

    public boolean findPath(){
        if(root == null || sequence ==  null || sequence.length == 0) return false;
        return findPath(root, sequence, 0);
    }

    private boolean findPath(TreeNode currentNode, int[] seq, int index){
        if(currentNode == null) return false;
        if(index >= seq.length) return false;

        if(currentNode.value == seq[index] && currentNode.IsLeaf()) return true;

        return findPath(currentNode.left,seq,index + 1) || findPath(currentNode.right, seq, index + 1);
    }

}
