package com.fruitfactory.subsets.subsetswithduplicates;

import java.util.*;

public class SubsetsWithDuplicates {

    private int[] _nums;

    public SubsetsWithDuplicates(int[] _nums) {
        this._nums = _nums;
    }

    public List<List<Integer>> findSubsets(){
        if(_nums == null || _nums.length == 0){
            return null;
        }

        Arrays.sort(_nums);

        List<List<Integer>> subsets = new ArrayList<>();
        subsets.add(new ArrayList<>());

        int startIndex = 0, endIndex = 0;

        for (int i = 0; i < _nums.length; i++) {
            startIndex = 0;

            if(i > 0 && _nums[i] == _nums[i-1]){
                startIndex = endIndex + 1;
            }

            endIndex = subsets.size() - 1;

            for (int j = startIndex; j <= endIndex; j++) {
                List<Integer> set = new ArrayList<>(subsets.get(j));
                set.add(_nums[i]);
                subsets.add(set);
            }
        }
        return subsets;
    }

}
