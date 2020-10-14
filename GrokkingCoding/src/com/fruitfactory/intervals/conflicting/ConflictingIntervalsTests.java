package com.fruitfactory.intervals.conflicting;

import com.fruitfactory.intervals.Interval;
import org.junit.Test;
import static org.junit.Assert.*;

public class ConflictingIntervalsTests {

    @Test
    public void FirstTest(){
        Interval[] intervals = new Interval[]{new Interval(1, 4), new Interval(2, 5), new Interval(7, 9) };
        ConflictingIntervals ci = new ConflictingIntervals();

        boolean result = ci.isConflicting(intervals);

        assertTrue(result);
    }

    @Test
    public void SecondTest(){
        Interval[] intervals = new Interval[]{new Interval(6, 7), new Interval(2, 4), new Interval(8, 12) };
        ConflictingIntervals ci = new ConflictingIntervals();

        boolean result = ci.isConflicting(intervals);

        assertFalse(result);
    }

    @Test
    public void ThirdTest(){
        Interval[] intervals = new Interval[]{new Interval(4, 5), new Interval(2, 3), new Interval(3, 6) };
        ConflictingIntervals ci = new ConflictingIntervals();

        boolean result = ci.isConflicting(intervals);

        assertTrue(result);
    }

}
