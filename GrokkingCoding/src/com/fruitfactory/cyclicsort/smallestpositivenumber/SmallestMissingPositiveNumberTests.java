package com.fruitfactory.cyclicsort.smallestpositivenumber;

import org.junit.Test;
import static org.junit.Assert.*;

public class SmallestMissingPositiveNumberTests {

    @Test
    public void FirstTest(){
        int[] arr = new int[]{-3, 1, 5, 4, 2};
        SmallestMissingPositiveNumber smpn = new SmallestMissingPositiveNumber();
        int result = smpn.findMissingPositiveNumber(arr);

        assertEquals(3, result);
    }

    @Test
    public void SecondTest(){
        int[] arr = new int[]{3, -2, 0, 1, 2};
        SmallestMissingPositiveNumber smpn = new SmallestMissingPositiveNumber();
        int result = smpn.findMissingPositiveNumber(arr);

        assertEquals(4, result);
    }

    @Test
    public void ThirdTest(){
        int[] arr = new int[]{3, 2, 5, 1};
        SmallestMissingPositiveNumber smpn = new SmallestMissingPositiveNumber();
        int result = smpn.findMissingPositiveNumber(arr);

        assertEquals(4, result);
    }

}
