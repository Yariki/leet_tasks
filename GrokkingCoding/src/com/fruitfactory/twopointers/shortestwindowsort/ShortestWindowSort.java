package com.fruitfactory.twopointers.shortestwindowsort;

public class ShortestWindowSort {

    public int sort(int[] arr) {

        int min = arr[0], max = arr[arr.length - 1];
        int left = 0, right = arr.length - 1;

        int leftBorder = -1, rightBorder = -1;

        while (left < arr.length - 2 && 0 < right){

            if(min > arr[left]){
                leftBorder = 0;
            }
            if(arr[left] > arr[left + 1] && leftBorder == -1){
                leftBorder = left;
            }
            if(max < arr[right]){
                rightBorder = arr.length - 1;
            }
            if(arr[right - 1] > arr[right] && rightBorder == -1){
                rightBorder = right;
            }
            left++;
            right--;
        }
        return leftBorder == -1 && rightBorder == -1 ? 0 : Math.abs(rightBorder - leftBorder) + 1;
    }

    public int sort2(int[] arr){
        int low = 0, high = arr.length -1;

        while(low < arr.length - 1 && arr[low] <= arr[low + 1])
            low++;

        if(low == arr.length - 1)
            return 0;

        while(high > 0 && arr[high] >= arr[high - 1])
            high--;

        int subMax = Integer.MIN_VALUE, subMin = Integer.MAX_VALUE;

        for (int i = low; i < high; i++) {
            subMax = Math.max(subMax,arr[i]);
            subMin = Math.min(subMin,arr[i]);
        }

        while (low > 0 && arr[low - 1] > subMin)
            low--;

        while (high < arr.length -1 && arr[high + 1] < subMax)
            high++;

        return high - low + 1;
    }


}
