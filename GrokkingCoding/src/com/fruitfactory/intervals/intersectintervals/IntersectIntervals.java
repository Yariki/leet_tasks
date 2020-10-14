package com.fruitfactory.intervals.intersectintervals;

import com.fruitfactory.intervals.Interval;

import java.util.ArrayList;
import java.util.List;

public class IntersectIntervals {

    public Interval[] merge(Interval[] arr1, Interval[] arr2){
        List<Interval> result = new ArrayList<>();
        int i = 0, j = 0;
        while (i < arr1.length && j < arr2.length){
            if(
                    (arr1[i].getStart() >= arr2[j].getStart() && arr1[i].getStart() <= arr2[j].getEnd())
                    ||
                    (arr2[j].getStart() >= arr1[i].getStart() && arr2[j].getStart() <= arr1[i].getEnd())
            ){
                result.add(new Interval(Math.max(arr1[i].getStart(), arr2[j].getStart()), Math.min(arr1[i].getEnd(), arr2[j].getEnd())));
            }
            if(arr1[i].getEnd() < arr2[j].getEnd()){
                i++;
            } else{
                j++;
            }
        }

        return result.toArray(new Interval[result.size()]);
    }

}
