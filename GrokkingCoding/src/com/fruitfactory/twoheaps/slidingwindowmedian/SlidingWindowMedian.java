package com.fruitfactory.twoheaps.slidingwindowmedian;

import java.util.Collections;
import java.util.PriorityQueue;

public class SlidingWindowMedian {

    private PriorityQueue<Integer> maxHeap = new PriorityQueue<>(Collections.reverseOrder());
    private PriorityQueue<Integer> minHeap = new PriorityQueue<>();


    public double[] findSlidingWindowMedian(int[] nums, int k){

        double[] result = new double[nums.length - k + 1];

        for (int i = 0; i < nums.length; i++) {
            if(maxHeap.size() == 0 || maxHeap.peek() >=nums[i]){
                maxHeap.add(nums[i]);
            } else {
                minHeap.add(nums[i]);
            }

            rebalanceHeap();

            if( i - k + 1 >= 0){
                if(maxHeap.size() == minHeap.size()){
                    result[i - k + 1] = maxHeap.peek() / 2.0 + minHeap.peek() / 2.0;        
                } else {
                    result [i - k + 1] = maxHeap.peek();
                }

                int removeElements = nums[i - k + 1];
                if(removeElements <= maxHeap.peek()){
                    maxHeap.remove(removeElements);
                } else {
                    minHeap.remove(removeElements);
                }
                rebalanceHeap();
            }
        }

        return result;
    }

    private void rebalanceHeap(){
        if(maxHeap.size() > minHeap.size() + 1){
            minHeap.add(maxHeap.poll());
        } else if (maxHeap.size() < minHeap.size()){
            maxHeap.add(minHeap.poll());
        }
    }
}
