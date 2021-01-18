package com.fruitfactory.dfs.sumofpathnumbers;

import com.fruitfactory.helpers.TreeNode;

import java.lang.reflect.AnnotatedArrayType;
import java.util.ArrayList;
import java.util.List;

public class SumOfPathNumbers {
    private TreeNode root;

    public SumOfPathNumbers(TreeNode root) {
        this.root = root;
    }


    public int findSumOfPathNumbers2(){
        return findRootToLeafNumbers(root,0);
    }

    private int findRootToLeafNumbers(TreeNode currentNode, int pathSum){
        if(currentNode == null) return 0;
        pathSum = 10 * pathSum + currentNode.value;
        if(currentNode.IsLeaf()){
            return pathSum;
        }
        return findRootToLeafNumbers(currentNode.left, pathSum) + findRootToLeafNumbers(currentNode.right, pathSum);
    }


    public int findSumOfPathNumbers(){
        if (root == null) return 0;

        List<Integer> numbers = new ArrayList<>();

        findAllNumbers(root, 0, numbers);

        int sum  = 0;
        for (int i = 0; i < numbers.size(); i++) {
            sum += numbers.get(i);
        }
        return sum;
    }

    private void findAllNumbers(TreeNode currentNode, int previousNum, List<Integer> numbers){

        if(currentNode == null) return;

        previousNum = previousNum * 10;

        if(currentNode.IsLeaf()){
            numbers.add(previousNum + currentNode.value);
            return;
        }

        findAllNumbers(currentNode.left, previousNum + currentNode.value, numbers);

        findAllNumbers(currentNode.right, previousNum + currentNode.value, numbers);
    }

}
