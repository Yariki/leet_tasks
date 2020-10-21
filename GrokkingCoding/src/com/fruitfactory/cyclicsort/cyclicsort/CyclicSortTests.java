package com.fruitfactory.cyclicsort.cyclicsort;

import org.junit.Test;
import static org.junit.Assert.*;

public class CyclicSortTests {

    @Test
    public void FirstTests(){
        int[] arr = new int[]{3,1,5,4,2};
        CyclicSort cs = new CyclicSort();
        int[] result = cs.sort(arr);

        assertArrayEquals(new int[]{1,2,3,4,5}, result);
    }

    @Test
    public void SecondTests(){
        int[] arr = new int[]{2,6,4,3,1,5};
        CyclicSort cs = new CyclicSort();
        int[] result = cs.sort(arr);

        assertArrayEquals(new int[]{1,2,3,4,5,6}, result);
    }

    @Test
    public void ThirdTests(){
        int[] arr = new int[]{1,5,6,4,3,2};
        CyclicSort cs = new CyclicSort();
        int[] result = cs.sort(arr);

        assertArrayEquals(new int[]{1,2,3,4,5,6}, result);
    }



}
