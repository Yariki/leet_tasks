package com.fruitfactory.twopointers.dutchflagproblem;

import org.junit.Test;
import static org.junit.Assert.*;
import java.util.List;

public class DutchFlagProblemTests {

    @Test
    public void FirstTest(){
        int[] arr = new int[] {1,0,2,1,0};
        DutchFlagProblem product = new DutchFlagProblem();
        product.sort(arr);

        assertArrayEquals(new int[]{0,0,1,1,2}, arr);
    }

    @Test
    public void SecondTest(){
        int[] arr = new int[] {2,2,0,1,2,0};
        DutchFlagProblem product = new DutchFlagProblem();
        product.sort(arr);

        assertArrayEquals(new int[]{0,0,1,2,2,2}, arr);
    }

}
