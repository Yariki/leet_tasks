package com.fruitfactory.cyclicsort.missingnumbers;

import org.junit.Test;

import java.util.Arrays;
import java.util.List;

import static org.junit.Assert.*;

public class MissingNumbersTests {

    @Test
    public void FirstTest(){
        int[] arr = new int[]{2, 3, 1, 8, 2, 3, 5, 1};
        MissingNumbers mns = new MissingNumbers();
        List<Integer> result = mns.findMissingNumbers(arr);

        Integer[] res = new Integer[result.size()];
        Integer[] res2 = result.toArray(res);
        assertArrayEquals(new Integer[]{4,6,7}, res2);
    }

    @Test
    public void SecondTest(){
        int[] arr = new int[]{2, 4, 1, 2};
        MissingNumbers mns = new MissingNumbers();
        List<Integer> result = mns.findMissingNumbers(arr);

        Integer[] res = new Integer[result.size()];
        Integer[] res2 = result.toArray(res);
        assertArrayEquals(new Integer[]{3}, res2);
    }

    @Test
    public void ThirdTest(){
        int[] arr = new int[]{2, 3, 2, 1};
        MissingNumbers mns = new MissingNumbers();
        List<Integer> result = mns.findMissingNumbers(arr);

        Integer[] res = new Integer[result.size()];
        Integer[] res2 = result.toArray(res);
        assertArrayEquals(new Integer[]{4}, res2);
    }

}
