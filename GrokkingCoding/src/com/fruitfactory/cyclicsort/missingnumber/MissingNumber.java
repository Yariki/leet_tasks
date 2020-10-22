package com.fruitfactory.cyclicsort.missingnumber;

import java.util.Arrays;

public class MissingNumber {

    public int findMissingNumber(int[] arr){

        if(arr == null || arr.length == 0) return -1;

        int i = 0;

        while(i < arr.length){
            if(arr[i] < arr.length && arr[i] != arr[arr[i]]){
                swap(arr, i, arr[i]);
            } else {
                i++;
            }
        }

        for (int j = 0; j < arr.length; j++) {
            if(arr[j] != j){
                return j;
            }
        }

        return arr.length;
    }

    private void swap (int[] arr, int i, int j){
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

}
