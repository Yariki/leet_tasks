package com.fruitfactory.cyclicsort.findallduplicates;

import org.junit.Test;
import static org.junit.Assert.*;

public class FindAllDuplicatesTests {

    @Test
    public void FirstTest(){
        int[] arr = new int[]{3, 4, 4, 5, 5};
        FindAllDuplicates fad = new FindAllDuplicates();
        Integer[] result = fad.findAllDuplicates(arr);

        assertArrayEquals(new Integer[]{5,4}, result);
    }


    @Test
    public void SecondTest(){
        int[] arr = new int[]{5, 4, 7, 2, 3, 5, 3};
        FindAllDuplicates fad = new FindAllDuplicates();
        Integer[] result = fad.findAllDuplicates(arr);

        assertArrayEquals(new Integer[]{3,5}, result);
    }

}
