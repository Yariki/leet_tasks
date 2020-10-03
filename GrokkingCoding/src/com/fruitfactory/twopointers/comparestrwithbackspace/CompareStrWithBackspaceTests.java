package com.fruitfactory.twopointers.comparestrwithbackspace;

import org.junit.Test;
import static org.junit.Assert.*;
import java.util.List;

public class CompareStrWithBackspaceTests {

    @Test
    public void FirstTest() {
        String str1 = "xy#z";
        String str2 = "xzz#";

        CompareStrWithBackspace c = new CompareStrWithBackspace();
        boolean res = c.compare(str1, str2);

        assertTrue(res);
    }

    @Test
    public void SecondTest() {
        String str1 = "xy#z";
        String str2 = "xyz#";

        CompareStrWithBackspace c = new CompareStrWithBackspace();
        boolean res = c.compare(str1, str2);

        assertFalse(res);
    }


    @Test
    public void ThirdTest() {
        String str1 = "xp#";
        String str2 = "xyz##";

        CompareStrWithBackspace c = new CompareStrWithBackspace();
        boolean res = c.compare(str1, str2);

        assertTrue(res);
    }


    @Test
    public void FourthTest() {
        String str1 = "xywrrmp";
        String str2 = "xywrrmu#p";

        CompareStrWithBackspace c = new CompareStrWithBackspace();
        boolean res = c.compare(str1, str2);

        assertTrue(res);
    }


}
