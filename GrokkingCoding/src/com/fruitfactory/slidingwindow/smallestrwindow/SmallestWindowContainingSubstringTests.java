package com.fruitfactory.slidingwindow.smallestrwindow;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class SmallestWindowContainingSubstringTests {

    @Test
    void FirstTest(){
        SmallestWindowContainingSubstring smallWindows = new SmallestWindowContainingSubstring();
        String result = smallWindows.findSubstring("aabdec","abc");

        assertEquals("abdec", result);
;    }


    @Test
    void SecondTest(){
        SmallestWindowContainingSubstring smallWindows = new SmallestWindowContainingSubstring();
        String result = smallWindows.findSubstring("abdabca","abc");

        assertEquals("abc", result);

    }

    @Test
    void ThirdTest(){
        SmallestWindowContainingSubstring smallWindows = new SmallestWindowContainingSubstring();
        String result = smallWindows.findSubstring("adcad","abc");

        assertEquals("", result);

    }
}
