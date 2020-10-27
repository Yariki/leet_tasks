package com.fruitfactory.cyclicsort.findduplicate;

import com.fruitfactory.cyclicsort.ArrayExtensions;

public class FindDuplicate {


    public int findDuplicate(int[] arr){
        int i = 0;
        while(i < arr.length) {
            if(arr[i] != i+1){
                if(arr[i] != arr[arr[i] - 1]){
                    ArrayExtensions.swap(arr,i,arr[i] - 1);
                } else{
                    return arr[i];
                }
            }else{
                i++;
            }
        }
        return -1;
    }


}
