package com.fruitfactory.subsets.permutations;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

public class Permutations {

    private int[] _nums;

    public Permutations(int[] _nums) {
        this._nums = _nums;
    }


    public List<List<Integer>> findPermutations(){

        if(_nums == null || _nums.length == 0){
            return null;
        }

        List<List<Integer>> result = new ArrayList<>();
        Queue<List<Integer>> permutations = new LinkedList<>();
        
        permutations.add(new ArrayList<>());

        for (int currentNumber: _nums){
            int n = permutations.size();

            for (int i = 0; i < n; i++) {
                List<Integer> old = permutations.poll();
                for (int j = 0; j <= old.size(); j++) {
                    List<Integer> newPerm = new ArrayList<>(old);
                    newPerm.add(j,currentNumber);

                    if(newPerm.size() == _nums.length){
                        result.add(newPerm);
                    }else{
                        permutations.add(newPerm);
                    }
                }
            }
        }
        return result;
    }
}
