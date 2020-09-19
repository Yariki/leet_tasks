package com.fruitfactory.twopointers.tripletswithsmallsum;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class TripletsWithSmallSumTests {

    @Test
    public void FirstTest(){
        int[] arr = new int[] {-1, 0, 2, 3};
        int target = 3;
        TripletsWithSmallSum tripletsWithSmallSum = new TripletsWithSmallSum();
        int result = tripletsWithSmallSum.searchTriplets(arr,target);

        assertEquals(2, result);
    }

    @Test
    public void SecondTest(){
        int[] arr = new int[] {-1, 4, 2, 1, 3};
        int target = 5;
        TripletsWithSmallSum tripletsWithSmallSum = new TripletsWithSmallSum();
        int result = tripletsWithSmallSum.searchTriplets(arr,target);

        assertEquals(4, result);
    }

}
