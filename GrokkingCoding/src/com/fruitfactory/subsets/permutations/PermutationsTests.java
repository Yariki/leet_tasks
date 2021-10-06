package com.fruitfactory.subsets.permutations;

import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;


public class PermutationsTests {


    @Test
    public void FirstCase_Success(){
        Permutations perm = new Permutations(null);
        List<List<Integer>> result = perm.findPermutations();

        assertNull(result);
    }

    @Test
    public void SecondCase_Success(){
        Permutations perm = new Permutations(new int[] {1,3});
        List<List<Integer>> result = perm.findPermutations();

        assertEquals(2, result.size());
        assertEquals(3, (int)result.get(0).get(0));
        assertEquals(1, (int)result.get(0).get(1));

        assertEquals(1, (int)result.get(1).get(0));
        assertEquals(3, (int)result.get(1).get(1));
    }

    @Test
    public void ThirdCase_Success(){
        Permutations perm = new Permutations(new int[] {1,3,5});
        List<List<Integer>> result = perm.findPermutations();

        assertEquals(6, result.size());
        assertEquals(5, (int)result.get(0).get(0));
        assertEquals(3, (int)result.get(0).get(1));
        assertEquals(1, (int)result.get(0).get(2));

        assertEquals(5, (int)result.get(3).get(0));
        assertEquals(1, (int)result.get(3).get(1));
        assertEquals(3, (int)result.get(3).get(2));
    }



}
