package com.fruitfactory.cyclicsort.findfirstkmissingpositivenumbers;

import com.fruitfactory.cyclicsort.ArrayExtensions;
import org.junit.Test;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

import static  org.junit.Assert.*;

public class FindFirstKMissingPositiveNumbers {

    public Integer[] findFirstKMissingPositiveNumbers(int[] arr, int k){
        int i = 0;
        while(i < arr.length){
            if(arr[i] > 0  && arr[i] <= arr.length && arr[i] != arr[arr[i] - 1]){
                ArrayExtensions.swap(arr,i, arr[i] - 1);
            } else{
                i++;
            }
        }

        List<Integer> missing = new ArrayList<>();
        Set<Integer> set = new HashSet<Integer>();
        for (i = 0; i < arr.length && missing.size() < k; i++) {
            if(arr[i] != i + 1){
                missing.add(i + 1);
                set.add(arr[i]);
            }
        }

        for (i = 1; missing.size() < k; i++){

            int next = i + arr.length;
            if(!set.contains(next)){
                missing.add(next);
            }
        }

        Integer[] a = new Integer[missing.size()];
        return  missing.toArray(a);
    }


}
