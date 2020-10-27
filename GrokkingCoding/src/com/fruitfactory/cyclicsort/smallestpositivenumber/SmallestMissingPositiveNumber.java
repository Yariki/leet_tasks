package com.fruitfactory.cyclicsort.smallestpositivenumber;

import com.fruitfactory.cyclicsort.ArrayExtensions;

public class SmallestMissingPositiveNumber {

    public  int findMissingPositiveNumber(int[] arr){
        int i = 0;
        while(i < arr.length){
            if(arr[i] > 0 && arr[i] < arr.length && arr[i] != arr[arr[i] - 1]){
                ArrayExtensions.swap(arr,i,arr[i] - 1);
            }else{
                i++;
            }
        }

        for (int j = 0; j < arr.length; j++) {
            if(arr[j] != j + 1){
                return j+1;
            }
        }
        return arr.length + 1;

    }

}
