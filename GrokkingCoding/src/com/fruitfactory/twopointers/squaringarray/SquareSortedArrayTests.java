package com.fruitfactory.twopointers.squaringarray;

import org.junit.Test;
import static org.junit.Assert.*;
import java.util.List;
public class SquareSortedArrayTests {

    @Test
    public void FirstTest(){
        int[] arr = new int[]{-2, -1, 0, 2, 3};
        SquareSortedArray sa = new SquareSortedArray();
        int[] result = sa.makeSquares(arr);

        assertArrayEquals(new int[] {0, 1, 4, 4, 9}, result);
    }


    @Test
    public void SecondTest(){
        int[] arr = new int[]{-3, -1, 0, 1, 2};
        SquareSortedArray sa = new SquareSortedArray();
        int[] result = sa.makeSquares(arr);

        assertArrayEquals(new int[] {0, 1, 1, 4, 9}, result);
    }
}
