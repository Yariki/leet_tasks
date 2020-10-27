package com.fruitfactory.cyclicsort.findcoruptpair;

import com.fruitfactory.cyclicsort.ArrayExtensions;

public class FindCoruptPair {

    public int[] findCorruptPair(int[] arr){
        int i = 0;
        while(i < arr.length){
            if(arr[i] != arr[arr[i] - 1]){
                ArrayExtensions.swap(arr, i, arr[i] - 1);
            } else{
                i++;
            }
        }

        int[] result = new int[2];
        for (int j = 0; j < arr.length; j++) {
            if(arr[j]  != j + 1){
                result[0] = (arr[j]);
                result[1] = (j + 1);
            }
        }
        return result;
    }

}
