package com.fruitfactory.subsets.balancedparentheses;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class BalancedParenthesesTests {

    @Test
    public void FirstCase_Success(){
        BalancedParentheses bp = new BalancedParentheses(0);
        List<String> result = bp.generateValidParenthesis();

        assertNull(result);
    }

    @Test
    public void SecondCase_Success(){
        BalancedParentheses bp = new BalancedParentheses(2);
        List<String> result = bp.generateValidParenthesis();


        assertNotNull(result);
        assertEquals(2,result.size());

        assertEquals("(())", result.get(0));
        assertEquals("()()", result.get(1));
    }

    @Test
    public void  ThirdCase_Success(){
        BalancedParentheses bp = new BalancedParentheses(3);
        List<String> result = bp.generateValidParenthesis();

        assertNotNull(result);
        assertEquals(5,result.size());

        assertEquals("((()))", result.get(0));
        assertEquals("(()())", result.get(1));
        assertEquals("(())()", result.get(2));
        assertEquals("()(())", result.get(3));
        assertEquals("()()()", result.get(4));
    }


}
