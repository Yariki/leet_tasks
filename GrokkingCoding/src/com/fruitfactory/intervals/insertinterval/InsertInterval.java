package com.fruitfactory.intervals.insertinterval;

import com.fruitfactory.intervals.Interval;

import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;

public class InsertInterval {

    public List<Interval> insert(List<Interval> intervals, Interval newInterval) {

        if(intervals == null || intervals.isEmpty()){
            return Arrays.asList(newInterval);
        }

        List<Interval> mergedInterval = new LinkedList<>();
        int i = 0;

        while(i < intervals.size() && intervals.get(i).getEnd() < newInterval.getStart()){
            mergedInterval.add(intervals.get(i++));
        }

        while (i < intervals.size() && intervals.get(i).getStart() <= newInterval.getEnd()){
            newInterval.setStart(Math.min(intervals.get(i).getStart(), newInterval.getStart()));
            newInterval.setEnd(Math.max(intervals.get(i).getEnd(), newInterval.getEnd()));
            i++;
        }

        mergedInterval.add(newInterval);

        while (i < intervals.size()){
            mergedInterval.add(intervals.get(i++));
        }

        return mergedInterval;
    }

}
