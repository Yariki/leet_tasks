package com.fruitfactory.twopointers.pairsum;

import java.util.ArrayList;
import java.util.List;

public class PairSum {
    public int[] search(int[] arr, int targetSum) {

        int[] list = new int[2];
        int start = 0, end = arr.length - 1;


        while(start <= end){
            int temp = arr[start] + arr[end];

            if(temp == targetSum){
                list[0] = start;
                list[1] = end;
                break;
            }
            else if(temp < targetSum){
                start++;
            }
            else{
                end--;
            }
        }
        return list;
    }

}
