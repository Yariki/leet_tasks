package com.fruitfactory.twoheaps.slidingwindowmedian;

import org.junit.Test;

import static org.junit.Assert.*;

public class SlidingWindowMedianTests {

    @Test
    public void MedianSlidingWindow_FirstAttempt_Success(){
        SlidingWindowMedian swm = new SlidingWindowMedian();
        double[] result = swm.findSlidingWindowMedian(new int[] {1,2,-1,3,5}, 2);

        assertNotNull(result);
        assertEquals(4, result.length);
        assertArrayEquals(new double[] {1.5, 0.5, 1.0, 4.0}, result, 0.1);
    }


    @Test
    public void MedianSlidingWindow_SecondAttempt_Success(){
        SlidingWindowMedian swm = new SlidingWindowMedian();
        double[] result = swm.findSlidingWindowMedian(new int[] {1,2,-1,3,5}, 3);

        assertNotNull(result);
        assertEquals(3, result.length);
        assertArrayEquals(new double[] {1.0, 2.0, 3.0}, result, 0.1);
    }



}
