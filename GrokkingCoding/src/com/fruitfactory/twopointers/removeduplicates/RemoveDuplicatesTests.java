package com.fruitfactory.twopointers.removeduplicates;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class RemoveDuplicatesTests {

    @Test
    public void FirsTest(){
        int[] arr = new int[]{2, 3, 3, 3, 6, 9, 9};
        RemoveDuplicates remDup = new RemoveDuplicates() ;
        int result = remDup.remove(arr);

        assertEquals(4, result);
    }

    @Test
    public void SecondTest(){
        int[] arr = new int[]{2, 2, 2, 11};
        RemoveDuplicates remDup = new RemoveDuplicates() ;
        int result = remDup.remove(arr);

        assertEquals(2, result);
    }

    @Test
    public void ThirdTest(){
        int[] arr = new int[]{3, 2, 3, 6, 3, 10, 9, 3};
        int key = 3;
        RemoveDuplicates remDup = new RemoveDuplicates() ;
        int result = remDup.remove(arr,key);

        assertEquals(4, result);
    }

    @Test
    public void FourthTest(){
        int[] arr = new int[]{2, 11, 2, 2, 1};
        int key = 2;
        RemoveDuplicates remDup = new RemoveDuplicates() ;
        int result = remDup.remove(arr,key);

        assertEquals(2, result);
    }


}
