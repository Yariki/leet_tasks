package com.fruitfactory.cyclicsort.findfirstkmissingpositivenumbers;

import org.junit.Test;
import static org.junit.Assert.*;


public class FindFirstKMissingPositiveNumbersTests {

    @Test
    public void FirstTests() {
        int[] arr = new int[]{3, -1, 4, 5, 5};
        FindFirstKMissingPositiveNumbers fkn = new FindFirstKMissingPositiveNumbers();
        Integer[] result = fkn.findFirstKMissingPositiveNumbers(arr,3);

        assertArrayEquals(new Integer[]{1, 2, 6}, result);
    }

    @Test
    public void SecondTests() {
        int[] arr = new int[]{2, 3, 4};
        FindFirstKMissingPositiveNumbers fkn = new FindFirstKMissingPositiveNumbers();
        Integer[] result = fkn.findFirstKMissingPositiveNumbers(arr,3);

        assertArrayEquals(new Integer[]{1, 5, 6}, result);
    }

    @Test
    public void ThirdTests() {
        int[] arr = new int[]{-2, -3, 4};
        FindFirstKMissingPositiveNumbers fkn = new FindFirstKMissingPositiveNumbers();
        Integer[] result = fkn.findFirstKMissingPositiveNumbers(arr,2);

        assertArrayEquals(new Integer[]{1, 2}, result);
    }

}
