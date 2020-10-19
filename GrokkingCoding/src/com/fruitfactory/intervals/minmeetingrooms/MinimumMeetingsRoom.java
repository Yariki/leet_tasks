package com.fruitfactory.intervals.minmeetingrooms;

import com.fruitfactory.intervals.Interval;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.PriorityQueue;

public class MinimumMeetingsRoom {

    public int findMinimumMeetingRooms(List<Interval> meetings) {

        int result = -1;

        Collections.sort(meetings, (a,b) -> Integer.compare(a.getStart(),b.getStart()));

        result = findIntersections(meetings);

        return result;
    }

    private int findIntersections(List<Interval> intervals){

        List<Interval> result = new ArrayList<>();

        for (int i = 0; i < intervals.size() - 1;i++){
            for (int j = i + 1;j < intervals.size();j++){
                if(intervals.get(j).getStart() < intervals.get(i).getEnd()){
                    result.add(new Interval(Math.max(intervals.get(i).getStart(), intervals.get(j).getStart()), Math.min(intervals.get(i).getEnd(), intervals.get(j).getEnd())));
                }
            }
        }
        if(result.size() > 0){
            return 1 + findIntersections(result);
        }
        return 1;
    }


    public int findMinimumMeetingRooms2(List<Interval> meetings) {
        if(meetings == null || meetings.size() == 0) return 0;
        Collections.sort(meetings, (a,b) -> Integer.compare(a.getStart(), b.getStart()));

        int minRooms = 0;
        PriorityQueue<Interval> minHeap = new PriorityQueue<>(meetings.size(),(a,b) -> Integer.compare(a.getEnd(), b.getEnd()));
        for (Interval interval : meetings){
            while(!minHeap.isEmpty() && interval.getStart() >= minHeap.peek().getEnd())
                minHeap.poll();
            minHeap.offer(interval);
            minRooms = Math.max(minRooms,minHeap.size());
        }
        return minRooms;
    }

}
