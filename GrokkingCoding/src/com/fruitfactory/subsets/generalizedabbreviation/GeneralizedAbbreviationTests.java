package com.fruitfactory.subsets.generalizedabbreviation;

import org.junit.Test;
import org.junit.experimental.theories.suppliers.TestedOn;

import java.util.List;

import static org.junit.Assert.*;

public class GeneralizedAbbreviationTests {

    @Test
    public void FirstCase_Success(){
        GeneralizedAbbreviation ca = new GeneralizedAbbreviation(null);
        List<String> result = ca.generateGeneralizedAbbreviation();


        assertNull(result);
    }

    @Test
    public void SecondCase_Success(){
        GeneralizedAbbreviation ca = new GeneralizedAbbreviation("BAT");
        List<String> result = ca.generateGeneralizedAbbreviation();


        assertNotNull(result);
        assertEquals(8, result.size());

        assertEquals("BAT", result.get(7));
        assertEquals("BA1", result.get(6));
        assertEquals("B1T", result.get(5));
        assertEquals("B2", result.get(4));
        assertEquals("1AT", result.get(3));
        assertEquals("1A1", result.get(2));
        assertEquals("2T", result.get(1));
        assertEquals("3", result.get(0));

    }


}
