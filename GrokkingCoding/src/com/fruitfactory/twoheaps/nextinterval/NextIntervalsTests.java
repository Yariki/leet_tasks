package com.fruitfactory.twoheaps.nextinterval;


import org.junit.Test;

import static org.junit.Assert.*;

public class NextIntervalsTests {

    @Test
    public void NextIntervals_FirstAttempt_Success(){
        Interval[] intervals = new Interval[] { new Interval(2, 3), new Interval(3, 4), new Interval(5, 6) };
        NextInterval ni = new NextInterval(intervals);
        int[] result = ni.findNextIntervals();

        assertNotNull(result);
        assertEquals(3, result.length);
        assertArrayEquals(new int[] {1,2,-1}, result);
    }


    @Test
    public void NextINtervals_SecondAttempt_Success(){
        Interval[] intervals = new Interval[] { new Interval(3, 4), new Interval(1, 5), new Interval(4, 6) };
        NextInterval ni = new NextInterval(intervals);
        int[] result = ni.findNextIntervals();

        assertNotNull(result);
        assertEquals(3, result.length);
        assertArrayEquals(new int[] {2,-1,-1}, result);
    }

}
