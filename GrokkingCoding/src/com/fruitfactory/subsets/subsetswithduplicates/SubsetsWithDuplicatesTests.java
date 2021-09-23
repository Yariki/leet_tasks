package com.fruitfactory.subsets.subsetswithduplicates;


import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class SubsetsWithDuplicatesTests {

    @Test
    public void Null_Success(){
        SubsetsWithDuplicates subsets = new SubsetsWithDuplicates(null);
        List<List<Integer>> result = subsets.findSubsets();

        assertNull(result);
    }

    @Test
    public void FirstAttempt_Success(){
        SubsetsWithDuplicates subsets = new SubsetsWithDuplicates(new int[]{1,3,3});
        List<List<Integer>> result = subsets.findSubsets();

        assertNotNull(result);
        assertEquals(6,result.size());
        assertTrue(result.get(0).isEmpty());

        assertEquals(1,(int)result.get(1).get(0));
        assertEquals(3,(int)result.get(2).get(0));

        assertEquals(1,(int)result.get(3).get(0));
        assertEquals(3,(int)result.get(3).get(1));

        assertEquals(3,(int)result.get(4).get(0));
        assertEquals(3,(int)result.get(4).get(1));

        assertEquals(1,(int)result.get(5).get(0));
        assertEquals(3,(int)result.get(5).get(1));
        assertEquals(3,(int)result.get(5).get(1));

    }


}
