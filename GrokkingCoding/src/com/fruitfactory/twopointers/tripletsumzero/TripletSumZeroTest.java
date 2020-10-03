package com.fruitfactory.twopointers.tripletsumzero;

import org.junit.Test;
import static org.junit.Assert.*;
import java.util.List;


import java.util.*;

public class TripletSumZeroTest {

    @Test
    public void FirstTest(){
        int[] arr = new int[] { -3, 0, 1, 2, -1, 1, -2 };
        TripletSumZero tripleSum = new TripletSumZero();
        List<List<Integer>> result = tripleSum.searchTriplets(arr);

        assertArrayEquals(new int[]{-3, 1, 2}, result.get(0).stream().mapToInt(i -> i).toArray());
    }

    @Test
    public void SecondTest(){
        int[] arr = new int[] { -5, 2, -1, -2, 3 };
        TripletSumZero tripleSum = new TripletSumZero();
        List<List<Integer>> result = tripleSum.searchTriplets(arr);

        assertArrayEquals(new int[]{-5, 2, 3}, result.get(0).stream().mapToInt(i -> i).toArray());
    }


}
