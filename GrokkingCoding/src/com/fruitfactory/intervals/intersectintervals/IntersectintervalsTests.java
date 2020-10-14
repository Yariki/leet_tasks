package com.fruitfactory.intervals.intersectintervals;

import com.fruitfactory.intervals.Interval;
import org.junit.Test;
import static org.junit.Assert.*;

public class IntersectintervalsTests {

    @Test
    public void FirstTest(){
        Interval[] input1 = new Interval[] { new Interval(1, 3), new Interval(5, 6), new Interval(7, 9) };
        Interval[] input2 = new Interval[] { new Interval(2, 3), new Interval(5, 7) };
        IntersectIntervals ii = new IntersectIntervals();
        Interval[] result = ii.merge(input1,input2);

        assertEquals(3, result.length);
        assertEquals(2, result[0].getStart());
        assertEquals(3, result[0].getEnd());
        assertEquals(5, result[1].getStart());
        assertEquals(6, result[1].getEnd());
        assertEquals(7, result[2].getStart());
        assertEquals(7, result[2].getEnd());
    }

    @Test
    public void SecondTest(){
        Interval[] input1 = new Interval[] { new Interval(1, 3), new Interval(5, 7), new Interval(9, 12) };
        Interval[] input2 = new Interval[] { new Interval(5, 10) };
        IntersectIntervals ii = new IntersectIntervals();
        Interval[] result = ii.merge(input1,input2);

        assertEquals(2, result.length);
        assertEquals(5, result[0].getStart());
        assertEquals(7, result[0].getEnd());
        assertEquals(9, result[1].getStart());
        assertEquals(10, result[1].getEnd());
    }

}
