package com.fruitfactory.dfs.allpathsum;

import com.fruitfactory.helpers.TreeNode;

import java.util.ArrayList;
import java.util.List;
import java.util.Stack;

public class AllPathSum {

    private TreeNode root;
    private int sum;

    public AllPathSum(TreeNode root, int sum) {
        this.root = root;
        this.sum = sum;
    }

    public List<List<Integer>> findAllPath(){
        List<List<Integer>> result = new ArrayList<>();
        Stack<Integer> currentPath = new Stack<>();

        findAllPath(root, sum, currentPath, result);

        return result;
    }

    private void findAllPath(TreeNode currentNode, int sum, Stack<Integer> currentPath, List<List<Integer>> result) {

        if(currentNode == null) return;

        currentPath.push(currentNode.value);

        if(currentNode.value == sum && currentNode.IsLeaf()){
            result.add(new ArrayList<>(currentPath));
        } else{
            findAllPath(currentNode.left, sum - currentNode.value, currentPath, result);

            findAllPath(currentNode.right, sum - currentNode.value, currentPath, result);
        }

        currentPath.pop();
    }

}
