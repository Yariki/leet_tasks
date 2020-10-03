package com.fruitfactory.twopointers.productlessthantarget;

import org.junit.Test;
import static org.junit.Assert.*;
import java.util.List;

public class ProductLessThanTargetTests {

    @Test
    public void FirstTest(){
        int[] arr = new int[] {2,5,3,10};
        int target = 30;
        ProductLessThanTarget product = new ProductLessThanTarget();
        List<List<Integer>> result = product.findSubarrays(arr,target);

        assertEquals(6, result.size());
    }

    @Test
    public void SecondTest(){
        int[] arr = new int[] {8,2,6,5};
        int target = 50;
        ProductLessThanTarget product = new ProductLessThanTarget();
        List<List<Integer>> result = product.findSubarrays(arr,target);

        assertEquals(7, result.size());
    }

}
