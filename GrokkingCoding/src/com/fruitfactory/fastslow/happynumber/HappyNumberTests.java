package com.fruitfactory.fastslow.happynumber;

import org.junit.Test;
import static org.junit.Assert.*;

public class HappyNumberTests {

    @Test
    public void FirstTest(){
        boolean result = new HappyNumber().find(23);

        assertTrue(result);
    }


    @Test
    public void SecondTest(){
        boolean result = new HappyNumber().find(12);

        assertFalse(result);
    }



}
