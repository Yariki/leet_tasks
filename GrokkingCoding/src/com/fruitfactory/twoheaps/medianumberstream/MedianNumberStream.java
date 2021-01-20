package com.fruitfactory.twoheaps.medianumberstream;

import java.util.PriorityQueue;

public class MedianNumberStream {

    private PriorityQueue<Integer> min;
    private PriorityQueue<Integer> max;

    public MedianNumberStream() {

        min = new PriorityQueue<>((a,b) -> a - b);
        max = new PriorityQueue<>((a,b) -> b - a);
    }

    public void insert(int num){
        if(max.isEmpty() || max.peek() >= num){
            max.add(num);
        } else
            min.add(num);

        if(max.size() > min.size() + 1){
            min.add(max.poll());
        } else if (max.size() < min.size()){
            max.add(min.poll());
        }
    }

    public double median(){
        if(max.size() == min.size()){
            return max.peek() / 2.0 + min.peek() / 2.0;
        }

        return max.peek();
    }

}
