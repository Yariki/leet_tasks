package com.fruitfactory.twopointers.pairsum;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class PairSumTests {

    @Test
    public void FirstTest(){
        int[] arr = new int[]{1, 2, 3, 4, 6};
        PairSum sum = new PairSum();
        int[] result = sum.search(arr,6);

        assertEquals(1, result[0]);
        assertEquals(3, result[1]);
    }
}
