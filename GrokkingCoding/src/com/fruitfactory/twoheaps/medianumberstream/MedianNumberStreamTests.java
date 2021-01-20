package com.fruitfactory.twoheaps.medianumberstream;

import org.junit.Test;

import static org.junit.Assert.*;


public class MedianNumberStreamTests {

    @Test
    public void MedianOfNumbersTest(){
        MedianNumberStream mns = new MedianNumberStream();
        mns.insert(3);
        mns.insert(1);

        double result = mns.median();

        assertEquals(2.0, result, 0.1);

        mns.insert(5);

        result = mns.median();

        assertEquals(3.0, result, 0.1);

        mns.insert(4);

        result = mns.median();

        assertEquals(3.5, result, 0.1);

    }

}
