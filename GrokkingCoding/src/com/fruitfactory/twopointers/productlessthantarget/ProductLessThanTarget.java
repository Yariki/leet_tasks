package com.fruitfactory.twopointers.productlessthantarget;

import java.util.*;

public class ProductLessThanTarget {
    public List<List<Integer>> findSubarrays(int[] arr, int target) {
        List<List<Integer>> subarrays = new ArrayList<>();

        int product = 1, left = 0;

        for (int right = 0; right < arr.length; right++) {
            product *= arr[right];
            while(product >= target && left < arr.length){
                product /= arr[left++];
            }
            List<Integer> temp = new LinkedList<>();
            for (int i = right; i >= left ; i--) {
                temp.add(0,arr[i]);
                subarrays.add(new ArrayList<>(temp));
            }
        }
        return subarrays;
    }
}
