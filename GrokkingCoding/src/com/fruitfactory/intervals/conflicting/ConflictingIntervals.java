package com.fruitfactory.intervals.conflicting;

import com.fruitfactory.intervals.Interval;

import java.util.Arrays;
import java.util.Collections;

public class ConflictingIntervals {

    public boolean isConflicting(Interval[] intervals){

        if(intervals == null || intervals.length == 0)
            return false;

        Arrays.sort(intervals, (a, b) -> Integer.compare(a.getStart(), b.getStart()));

        for (int i = 1; i < intervals.length; i++) {
            if(intervals[i].getStart() < intervals[i-1].getEnd()){
                return true;
            }
        }
        return false;
    }

}
