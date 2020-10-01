package com.fruitfactory.twopointers.quadruple;

import org.junit.jupiter.api.Test;

import java.util.Arrays;
import java.util.List;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;
import static org.junit.jupiter.api.Assertions.assertEquals;

public class QuadrupleSumTargetTests {

    @Test
    public void FirstTest() {
        int[] arr = new int[]{4, 1, 2, -1, 1, -3};
        int target = 1;
        QuadrupleSumTarget qp = new QuadrupleSumTarget();
        List<List<Integer>> result = qp.searchQuadruplets(arr,target);

        assertEquals(2,result.toArray().length);

        int[] arr1 = new int[result.get(0).size()];
        for (int i = 0; i < result.get(0).size(); i++) {
            arr1[i] = result.get(0).get(i);
        }

        assertArrayEquals(new int[]{-3,-1,1,4}, arr1);
    }

    @Test
    public void SecondTest() {
        int[] arr = new int[]{2,0,-1,1,-2,2};
        int target = 2;
        QuadrupleSumTarget qp = new QuadrupleSumTarget();
        List<List<Integer>> result = qp.searchQuadruplets(arr,target);

        assertEquals(2,result.toArray().length);

        int[] arr1 = new int[result.get(0).size()];
        for (int i = 0; i < result.get(0).size(); i++) {
            arr1[i] = result.get(0).get(i);
        }

        assertArrayEquals(new int[]{-2,0,2,2}, arr1);
    }

}
