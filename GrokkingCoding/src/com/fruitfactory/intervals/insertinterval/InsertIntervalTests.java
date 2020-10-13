package com.fruitfactory.intervals.insertinterval;

import com.fruitfactory.intervals.Interval;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.*;

public class InsertIntervalTests {

    @Test
    public void FirstTest(){
        List<Interval> input = new ArrayList<Interval>();
        input.add(new Interval(1, 3));
        input.add(new Interval(5, 7));
        input.add(new Interval(8, 12));
        InsertInterval ii = new InsertInterval();
        List<Interval> result = ii.insert(input, new Interval(4,6));

        assertEquals(3, result.size());
        assertEquals(4, result.get(1).getStart());
        assertEquals(7, result.get(1).getEnd());
    }

    @Test
    public void SecondTest(){
        List<Interval> input = new ArrayList<Interval>();
        input.add(new Interval(1, 3));
        input.add(new Interval(5, 7));
        input.add(new Interval(8, 12));
        InsertInterval ii = new InsertInterval();
        List<Interval> result = ii.insert(input, new Interval(4,10));

        assertEquals(2, result.size());
        assertEquals(4, result.get(1).getStart());
        assertEquals(12, result.get(1).getEnd());
    }

}
