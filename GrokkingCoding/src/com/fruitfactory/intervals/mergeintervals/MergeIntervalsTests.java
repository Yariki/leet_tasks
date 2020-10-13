package com.fruitfactory.intervals.mergeintervals;

import com.fruitfactory.intervals.Interval;
import org.junit.Test;
import static org.junit.Assert.*;

import java.util.LinkedList;
import java.util.List;

public class MergeIntervalsTests {

    @Test
    public void FirstTest(){
        List<Interval> intervals = new LinkedList<>();
        intervals.add(new Interval(6,7));
        intervals.add(new Interval(2,4));
        intervals.add(new Interval(5,9));
        MergeIntervals mi =  new MergeIntervals();
        List<Interval> result = mi.merge(intervals);

        assertEquals(2, result.size());
        assertEquals(2, result.get(0).getStart());
        assertEquals(4, result.get(0).getEnd());

        assertEquals(5, result.get(1).getStart());
        assertEquals(9, result.get(1).getEnd());
    }

    @Test
    public void SecondTest(){
        List<Interval> intervals = new LinkedList<>();
        intervals.add(new Interval(1,4));
        intervals.add(new Interval(2,6));
        intervals.add(new Interval(3,5));
        MergeIntervals mi =  new MergeIntervals();
        List<Interval> result = mi.merge(intervals);

        assertEquals(1, result.size());
        assertEquals(1, result.get(0).getStart());
        assertEquals(6, result.get(0).getEnd());
    }




}
