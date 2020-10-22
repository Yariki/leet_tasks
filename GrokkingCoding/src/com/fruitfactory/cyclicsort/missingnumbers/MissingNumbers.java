package com.fruitfactory.cyclicsort.missingnumbers;

import java.util.ArrayList;
import java.util.List;

public class MissingNumbers {

    public List<Integer> findMissingNumbers(int[] arr){

        List<Integer> result = new ArrayList<>();

        int i= 0;
        while(i < arr.length){
            if(arr[i] != arr[arr[i] - 1]){
                swwap(arr,i,arr[i] - 1);
            } else{
                i++;
            }
        }

        for (int j = 0; j < arr.length; j++) {
            if(arr[j] != j + 1){
                result.add(j+1);
            }
        }
        return result;
    }

    private void swwap(int[] arr, int i, int j){
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

}
