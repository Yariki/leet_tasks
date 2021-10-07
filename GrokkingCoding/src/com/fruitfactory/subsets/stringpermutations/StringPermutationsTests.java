package com.fruitfactory.subsets.stringpermutations;

import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;


public class StringPermutationsTests {

    @Test
    public void FirstCase_Success(){
        StringPermutations str = new StringPermutations(null);
        List<String> result = str.findLetterCaseStringPermutations();

        assertNull(result);
    }


    @Test
    public void SecondCase_Success(){
        StringPermutations str = new StringPermutations("ad52");
        List<String> result = str.findLetterCaseStringPermutations();

        assertNotNull(result);
        assertEquals(4, result.size());
        assertEquals("ad52", result.get(0));
        assertEquals("Ad52", result.get(1));
        assertEquals("aD52", result.get(2));
        assertEquals("AD52", result.get(3));
    }


}
