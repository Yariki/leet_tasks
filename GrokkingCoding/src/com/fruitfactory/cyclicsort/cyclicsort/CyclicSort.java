package com.fruitfactory.cyclicsort.cyclicsort;

public class CyclicSort {


    public int[] sort(int[] arr){
        if(arr == null || arr.length == 0)
            return arr;

        int i= 0;

        while(i < arr.length){
            int j = arr[i] - 1;
            if(arr[i] != arr[j]){
                swap(arr,i,j);
            } else{
                i++;
            }
        }
        return arr;
    }

    private void swap(int[] arr, int i, int j){
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

}
