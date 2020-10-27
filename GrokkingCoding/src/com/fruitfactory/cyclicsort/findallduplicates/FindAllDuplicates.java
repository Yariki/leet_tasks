package com.fruitfactory.cyclicsort.findallduplicates;

import com.fruitfactory.cyclicsort.ArrayExtensions;

import java.util.ArrayList;
import java.util.List;

public class FindAllDuplicates {


    public Integer[] findAllDuplicates(int[] arr){

        int i = 0;
        while(i < arr.length){
            if(arr[i] != arr[arr[i] - 1]){
                ArrayExtensions.swap(arr,i,arr[i] - 1);
            }else{
                i++;
            }
        }
        List<Integer> dupl = new ArrayList<>();
        for (i = 0; i < arr.length; i++) {
            if(arr[i] != i + 1){
                dupl.add(arr[i]);
            }
        }
        Integer[] a = new Integer[dupl.size()];
        return dupl.toArray(a);
    }

}
