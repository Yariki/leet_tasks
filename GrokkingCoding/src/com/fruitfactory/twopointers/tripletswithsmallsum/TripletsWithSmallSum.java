package com.fruitfactory.twopointers.tripletswithsmallsum;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class TripletsWithSmallSum {
    public int searchTriplets(int[] arr, int target) {
        int count = 0;

        Arrays.sort(arr);
        for (int i = 0; i < arr.length - 2; i++) {
            count += searchPair(arr, target - arr[i], i);
        }

        return count;
    }

    private int searchPair(int[] arr, int targetSum, int first){
        int count = 0;
        int left = first + 1, right = arr.length - 1;
        while(left < right){
            if(arr[left] + arr[right] < targetSum){
                count += right - left;
                left++;
            } else{
                right--;
            }
        }
        return count;
    }

    public List<List<Integer>> returnTriplets(int[] arr, int target){
        Arrays.sort(arr);
        List<List<Integer>> triplets = new ArrayList<>();
        for (int i = 0; i < arr.length - 2; i++){
            searchPair(arr, target - arr[i], i, triplets);
        }
        return triplets;
    }

    private void searchPair(int[] arr, int targetSum, int first, List<List<Integer>> triplets){
        int left = first + 1, right = arr.length - 1;

        while(left < right){
            if(arr[left] + arr[right] < targetSum){
                for (int i = right; i > left; i-- ){
                    triplets.add(Arrays.asList(arr[first],arr[left], arr[i]));
                }
                left++;
            } else{
                right--;
            }
        }
    }



}


