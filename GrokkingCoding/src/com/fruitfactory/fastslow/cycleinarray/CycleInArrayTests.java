package com.fruitfactory.fastslow.cycleinarray;

import org.junit.Test;
import static  org.junit.Assert.*;

public class CycleInArrayTests {

    @Test
    public void  FirstTest(){
        int[] arr = new int[]{1, 2, -1, 2, 2};
        CycleInArray ca = new CycleInArray();
        boolean result = ca.loopExist(arr);

        assertTrue(result);
    }

    @Test
    public void  SecondTest(){
        int[] arr = new int[]{2, 2, -1, 2};
        CycleInArray ca = new CycleInArray();
        boolean result = ca.loopExist(arr);

        assertTrue(result);
    }

    @Test
    public void  ThirdTest(){
        int[] arr = new int[]{2, 1, -1, -2};
        CycleInArray ca = new CycleInArray();
        boolean result = ca.loopExist(arr);

        assertFalse(result);
    }

}
