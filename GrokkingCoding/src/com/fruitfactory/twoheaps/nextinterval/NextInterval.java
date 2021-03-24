package com.fruitfactory.twoheaps.nextinterval;

import java.util.PriorityQueue;

class Interval {
    int start  = 0;
    int end = 0;

    Interval(int start, int end){
        this.start = start;
        this.end = end;
    }
}

public class NextInterval {

    private Interval[] intervals;

    public NextInterval(Interval[] intervals) {
        this.intervals = intervals;
    }

    public int[] findNextIntervals(){
        int n = intervals.length;
        PriorityQueue<Integer> maxStartHeap = new PriorityQueue<>(n, (i1, i2) -> intervals[i2].start - intervals[i1].start);
        PriorityQueue<Integer> maxEndHeap = new PriorityQueue<>(n, (i1, i2) -> intervals[i2].end - intervals[i1].end);

        int[] result = new int[n];
        for (int i = 0; i < intervals.length; i++) {
            maxStartHeap.offer(i);
            maxEndHeap.offer(i);
        }
        for (int i = 0; i < n; i++) {
            int topEnd = maxEndHeap.poll();
            result[topEnd] = -1;
            if(intervals[maxStartHeap.peek()].start >= intervals[topEnd].end){
                int topStart = maxStartHeap.poll();

                while (!maxStartHeap.isEmpty() && intervals[maxStartHeap.peek()].start >= intervals[topEnd].end){
                    topStart = maxStartHeap.poll();
                }
                result[topEnd] = topStart;
                maxStartHeap.add(topStart);
            }
        }
        return result;
    }

}
