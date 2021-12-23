package com.fruitfactory.subsets.evaluateexpression;

import org.junit.Test;
import org.junit.experimental.theories.suppliers.TestedOn;

import java.util.List;

import static org.junit.Assert.*;

public class EvaluateExpressionTests {

    @Test
    public void Null_Success(){
        EvaluateExpression ee = new EvaluateExpression();
        List<Integer> result = ee.diffWaysToEvaluateExpression(null);

        assertNull(result);
    }

    @Test
    public void FirstAttempt(){
        EvaluateExpression ee = new EvaluateExpression();
        List<Integer> result = ee.diffWaysToEvaluateExpression("1+2*3");

        assertNotNull(result);
        assertTrue(result.size() == 2);

       assertTrue(result.get(0) == 7);
       assertTrue(result.get(1) == 9);
    }


}
