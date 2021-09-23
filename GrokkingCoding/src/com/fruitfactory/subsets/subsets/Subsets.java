package com.fruitfactory.subsets.subsets;

import java.util.ArrayList;
import java.util.List;

public class Subsets {

	private int[] _nums;

	public Subsets(int[] nums){
		_nums = nums;
	}

	public List<List<Integer>> findSubsets(){
		if(_nums == null || _nums.length == 0){
			return null;
		}
		List<List<Integer>> subsets = new ArrayList<>();
		subsets.add(new ArrayList<>());

		for (int currentNum : _nums){
			int n = subsets.size();

			for (int i = 0; i < n; i++) {
				List<Integer> subset = new ArrayList<>(subsets.get(i));
				subset.add(currentNum);
				subsets.add(subset);
			}
		}

		return subsets;
	}


}
