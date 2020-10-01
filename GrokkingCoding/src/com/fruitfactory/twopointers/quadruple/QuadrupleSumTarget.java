package com.fruitfactory.twopointers.quadruple;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class QuadrupleSumTarget {

    public List<List<Integer>> searchQuadruplets(int[] arr, int target) {
        Arrays.sort(arr);
        List<List<Integer>> quad = new ArrayList<>();
        for (int i = 0; i < arr.length - 3; i++) {
            if(i > 0 && arr[i] == arr[i-1])
                continue;
            for (int j = i + 1; j < arr.length - 2; j++) {
                if(j > 0 && arr[j] == arr[j-1])
                    continue;
                searchPairs(arr,target,i,j,quad);
            }
        }
        return quad;
    }

    private void searchPairs(int[] arr, int targetSum, int first, int second, List<List<Integer>> quadruplets) {
        int left = second + 1;
        int right = arr.length - 1;
        while(left < right){
            int sum = arr[first] + arr[second] + arr[left] + arr[right];
            if(sum == targetSum){
                quadruplets.add(Arrays.asList(arr[first], arr[second],arr[left], arr[right]));
                left++;
                right--;
                while(left < right && arr[left] == arr[left-1])
                    left++;
                while(left < right && arr[right] == arr[right + 1])
                    right--;
            } else if(sum < targetSum){
                left++;
            } else {
                right--;
            }
        }
    }
}
