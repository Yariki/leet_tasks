package com.fruitfactory.cyclicsort.findduplicate;

import org.junit.Test;
import static org.junit.Assert.*;

public class FindDuplicateTests {

    @Test
    public void FirstTests(){
        int[] arr = new int[]{1, 4, 4, 3, 2};
        FindDuplicate fd = new FindDuplicate();
        int result = fd.findDuplicate(arr);

        assertEquals(4, result);
    }

    @Test
    public void SecondTest(){
        int[] arr = new int[]{2, 1, 3, 3, 5, 4};
        FindDuplicate fd = new FindDuplicate();
        int result = fd.findDuplicate(arr);

        assertEquals(3, result);
    }

    @Test
    public void ThirdTest(){
        int[] arr = new int[]{2, 4, 1, 4, 4};
        FindDuplicate fd = new FindDuplicate();
        int result = fd.findDuplicate(arr);

        assertEquals(4, result);
    }

}
