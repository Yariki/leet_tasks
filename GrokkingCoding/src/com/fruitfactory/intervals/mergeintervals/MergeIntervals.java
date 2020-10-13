package com.fruitfactory.intervals.mergeintervals;

import com.fruitfactory.intervals.Interval;

import java.util.Collections;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;

public class MergeIntervals {

    public List<Interval> merge(List<Interval> intervals){
        if(intervals.size() < 2)
            return intervals;

        Collections.sort(intervals, (a,b) -> Integer.compare(a.getStart(),b.getStart()));
        List<Interval> mergedInt = new LinkedList<>();
        Iterator<Interval> iterator = intervals.iterator();
        Interval interval = iterator.next();
        int start = interval.getStart();
        int end = interval.getEnd();

        while(iterator.hasNext()){
            interval = iterator.next();

            if(interval.getStart() < end){
                end = Math.max(interval.getEnd(), end);
            } else{
                mergedInt.add(new Interval(start,end));
                start = interval.getStart();
                end = interval.getEnd();
            }
        }
        mergedInt.add(new Interval(start, end));

        return mergedInt;
    }

}
