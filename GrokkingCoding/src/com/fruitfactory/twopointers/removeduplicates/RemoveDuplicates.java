package com.fruitfactory.twopointers.removeduplicates;

public class RemoveDuplicates {


    public int remove(int[] arr){

        int nextduplicates = 1;
        for (int i = 1; i < arr.length; i++){
            if(arr[nextduplicates - 1] != arr[i]){
                arr[nextduplicates] = arr[i];
                nextduplicates++;
            }
        }
        return nextduplicates;
    }


    public int remove(int[] arr, int key){
        int next = 0;

        for (int i = 0; i < arr.length; i++) {
            if(arr[i] != key){
                arr[next] = arr[i];
                next++;
            }
        }
        return next;
    }

}
