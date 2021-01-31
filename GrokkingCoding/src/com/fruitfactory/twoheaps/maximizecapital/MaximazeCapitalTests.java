package com.fruitfactory.twoheaps.maximizecapital;

import org.junit.Test;
import static org.junit.Assert.*;


public class MaximazeCapitalTests {

    @Test
    public void FirstAttempt_Null_Success(){
        MaximazeCapital mc = new MaximazeCapital(null, null, 0,0);
        int result = mc.findMaxCapital();

        assertEquals(Integer.MIN_VALUE, result);
    }

    @Test
    public void SecondAttempt_Succes(){
        MaximazeCapital mc = new MaximazeCapital(new int[] { 0, 1, 2 }, new int[] { 1, 2, 3 }, 2,1);
        int result = mc.findMaxCapital();

        assertEquals(6, result);
    }

    @Test
    public void ThirdAttempt_Succes(){
        MaximazeCapital mc = new MaximazeCapital(new int[] { 0, 1, 2 ,3 }, new int[] { 1, 2, 3, 5  }, 3,0);
        int result = mc.findMaxCapital();

        assertEquals(8, result);
    }
}
