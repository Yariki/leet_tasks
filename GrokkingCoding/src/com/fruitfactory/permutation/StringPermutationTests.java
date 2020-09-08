package com.fruitfactory.permutation;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
public class StringPermutationTests {

    @Test
    void FirstTest(){
        StringPermutation perm = new StringPermutation();
        boolean result = perm.findPermutation("oidbcaf","abc");

        assertEquals(true, result);

    }
}
