package com.fruitfactory.cyclicsort.missingnumber;

import org.junit.Test;
import static org.junit.Assert.*;

public class MissingNumberTests {

    @Test
    public void FirstTest(){
        int[] arr = new int[]{4, 0, 3, 1};
        MissingNumber mn = new MissingNumber();
        int result = mn.findMissingNumber(arr);
        assertEquals(2, result);
    }

    @Test
    public void SecondTest(){
        int[] arr = new int[]{8, 3, 5, 2, 4, 6, 0, 1};
        MissingNumber mn = new MissingNumber();
        int result = mn.findMissingNumber(arr);
        assertEquals(7, result);
    }

}
