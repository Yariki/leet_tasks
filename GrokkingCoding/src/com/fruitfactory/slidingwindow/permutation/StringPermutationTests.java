package com.fruitfactory.slidingwindow.permutation;

import org.junit.Test;
import static org.junit.Assert.*;


public class StringPermutationTests {

    @Test
    void FirstTest(){
        StringPermutation perm = new StringPermutation();
        boolean result = perm.findPermutation("oidbcaf","abc");

        assertEquals(true, result);

    }
}
